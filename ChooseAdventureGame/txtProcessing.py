from OSFuncs import list_files
import os 
fileDir = os.path.join(os.getcwd(), "Docs")

# This is the fully qualified file Directory for the text files, This will be changing soon once OS functionality is implemented to make this more streamlined
txtContents = []
# This will hold all of the serialized contents of the text file
ctrlData = []
# This will hold the data used to control the flow of the game
displayData = []
# This will hold the data that helps determine how the game will display output to the player
ids = []
ins = []
outs = []
txts = []
# These lists will individually store all of the control data
masterDict = {}
# This will hold the master dictionary with all data formatted, processed, and compiled
def print_files(path):
    print('Your options are: ')
    files = list_files(path)
    for file in files:
        print(f'\t{file}. {files[file]}'.replace('.json', ''))
    return files
# display files in config folder
def seperateColorTag(txt, index, replacement):
    return txt.replace(txt[index:index+2], replacement), txt[index + 1]
# replace text replaces the targeted text with nothing to remove it from final display
def textSerializer(fileName):
    rawtxtContents = []
    with open( os.path.join(fileDir, fileName+".txt"), 'r') as adv:
        for line in adv:
            rawtxtContents.append(line.rstrip('\n'))
        
        for l in rawtxtContents:
            entry = ''
            if '$ID: ' in l:
                try:
                    for i in rawtxtContents[rawtxtContents.index(l):rawtxtContents.index(f'{l[:-2] + str(int(l[-2]) + 1)};')]:
                        entry += i
                    txtContents.append(entry)
                except ValueError:
                    for i in rawtxtContents[rawtxtContents.index(l):len(rawtxtContents)]:
                        entry += i
                    txtContents.append(entry)
    return txtContents
# text Serializer reads the file line by line, and creates txtContents list, so we don't havee xcessive file handling syntax, and helps parsing
def dictPrep(content):
    for entry in content:
        for char in entry:
            if char == '$':
                data = ''
                for subchar in entry:
                    if subchar == ';':
                        data += subchar
                        entry = entry.replace(data, '')
                        break
                    else:
                        data += subchar
                ctrlData.append(data)
            if char == '[':
                data = ''
                for subchar in entry:
                    if subchar == ']':
                        data += subchar
                        entry = entry.replace(data, '')
                        break
                    else:
                        data += subchar
                displayData.append(data.lstrip('[').rstrip(']'))
    return ctrlData, displayData
# dictPrep parses each character to seperate each group of info into a long string for later parsing, but seperates text data from the rest
def dataSeperator(ctrl, display):
    for i in ctrlData[0::3]:
        ids.append(i.lstrip('$ID: ').rstrip(';'))
    for i in ctrlData[1::3]:
        ins.append(i.lstrip('$I: ').rstrip(';').split(', '))
    for i in ctrlData[2::3]:
        outs.append(i.lstrip('$O: ').rstrip(';').split(', '))

    for txt in displayData:
        txts.append([])
        data = ''
        for char in txt:
            if char != ';':
                data += char
            else:
                txts[displayData.index(displayData[displayData.index(txt)])].append(data)
                data = ''
# dataSeperator seperates all of the data into seperate lists so it can be zipped together later for a master dictionary
def createDict():
    tempDict = {
        id:{'IN': inp,
            'OUT': out,
            'TXT': txt}
        for id, inp, out, txt in zip(ids, ins, outs, txts)
        }
    masterDict.update(tempDict)
# create Dict uses nested dictionary comprehension to create a master dictionary that serves as an address book for the program
def processTxt(fileName):
    ctrl, display = dictPrep(textSerializer(fileName))
    dataSeperator(ctrl, display)
    createDict()
    return masterDict
# processTxt combines all previous files, and returns masterDict