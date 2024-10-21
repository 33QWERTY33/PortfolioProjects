from txtProcessing import processTxt, fileDir
from saveFeature import loadSave, loadSaveFlag
from colorFeature import cprint, keyDecoder
from OSFuncs import list_files, clear_screen
from configHandling import config
import time as t
from random import randint

files = [i.replace('.txt', '') for i in list_files(fileDir).values() if '.txt' in i]
# Finds each file with .txt extension, and removes it to display only the file name
games = {str(files.index(i)):i for i in files}
# Selection of possible adventures to run through

def endFlag(choice):
    return choice == 'EXIT'
# raises a flag if the user asks to exit to avoid error message

def collectStartInfo():
    print('\nGames include')
    for i in games:
        print(f'\t{i}: ', games[i])
    #displaying games

    game = input('What game would you like to run through? (Choose number, random(r), or save file with commands: [load1, load2, load3]): ').upper()
    currentID = '1'
    # Default ID
    if loadSaveFlag(game):
        currentID, game = loadSave(game[-1])
    elif game == 'R':
        game = str(randint(0, len(games)))

    masterDict = processTxt(games[game])
    # This is the master directory for all of the contents of the text file

    return currentID, game, masterDict
# collectStartInfo func creates the currentID, game, and masterDict functions

def readText(currentID, masterDict):
    if currentID == '1':
        clear_screen()
        print(f'{"-" * 25}{config.header_text}{"-" * 25}')
    if config.char_by_char:
        for line in masterDict[currentID]['TXT']:
            rawLine, color = config.currentTxtFgColor(line)
            for char in rawLine:
                cprint(char, color, end = '')
                t.sleep(config.print_speed)
            print()
    else:
        for line in masterDict[currentID]['TXT']:
            cprint(*config.currentTxtFgColor(line))
            t.sleep(config.print_speed)

# The readText function displays the text in the file to the user (will have to make changes for when colored print is added)

def displayChoices(currentID, masterDict):
    cprint(f'\nChoices are: {masterDict[currentID]["IN"]}', keyDecoder(config.opt_fg_color))
# Display choices shows the choices in the "IN" key of the currentID dict

def choiceChecker(currentID, masterDict):
    choice = input('\n?   ').upper()
    while choice not in masterDict[currentID]["IN"]:
        if choice == 'EXIT':
            break
        elif choice == '':
            displayChoices(currentID, masterDict)
            choice = input('?   ').upper()
        elif choice[:-1] == 'SAVE':
            break
        elif len(choice) != 1:
            print('The choice you made doesn\'t have the correct amount of characters')
            choice = input('?   ').upper()
        elif choice not in masterDict[currentID]["IN"]:
            print('The choice you made does not appear in the list of choices')
            choice = input('?   ').upper()
        else:
            print('You\'ve stumped me, but something is wrong... fix it.')
            choice = input('?   ').upper()
    
    return choice
# choice checker validates user input to prevent errors

def pathFinder(currentID, choice, masterDict):
    for i in masterDict[currentID]['OUT']:
        if (i == 'SAVE1') or (i == 'SAVE2') or (i == 'SAVE3'):
            break
        if choice == i[0]:
            if len(i) == 2:
                return i[-1]
            elif len(i) == 3:
                return i[-2:]
            elif len(i) == 4:
                return i[-3:]
# pathFinder func extrapolates the correct path from the user input