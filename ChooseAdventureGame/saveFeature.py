import time as t
from txtProcessing import fileDir

def loadSaveFlag(game):
    return game[:-1] == 'LOAD'
# load save flag func raises true or false for load or not load (haven't had to use so far, may be removed in final)

def createSaveFlag(choice):
    return choice[:-1] == 'SAVE'
# create save flag func raises true or false for save or no save

def loadSave(fileNum):
    with open(f'{fileDir}Saves\\save_file{fileNum}.txt', 'r') as sf:
        currentID = sf.readline()
        game = sf.readline()
    return currentID.rstrip(), game
# loadSave overwrites default currentID, and game variables

def createSave(currentID, choice, game):
    if createSaveFlag(choice):
        t.sleep(.75)
        print('\n\nCreating save file...')
        with open(f'{fileDir}Saves\\save_file{choice[-1]}.txt', 'w') as sf:
            sf.write(f'{currentID} \n')
            sf.write(game)
        t.sleep(.75)
        print(f'\n\nSave file created in slot {choice[-1]}')
# create Save func overwrites one of 3 save files with currentID, and game number
