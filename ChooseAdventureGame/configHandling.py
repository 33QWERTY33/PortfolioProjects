from txtProcessing import fileDir
from colorFeature import keyDecoder
from txtProcessing import seperateColorTag, print_files
import json
import os

configFilePath = 'Docs\\Configs'
# This is the relative file path to the configs folder
def configureGame():
    files = print_files(configFilePath)
    game = input('What is the config file you would like to use? (choose number)  ')
    game = f'{files[game]}'
    while game not in files.values():
        print('You have to pick one of the previously listed options.')
        game = input('Try again: ')
        game += '.json'
    # Creates game variable, catches invalid input and formats

    filePath =  os.path.join(fileDir, "Configs", game)

    with open(filePath, 'r') as conf_file:
        conf = json.load(conf_file)
    # Loads desired file

    return conf
# ConfigureGame takes what config file you would like to use and stores the file data in a var called conf
class Config():
    def __init__(self):
        self.config = configureGame()
        self.header_text = self.config['header_text']
        self.txt_fg_color = self.config['txt_fg_color']
        self.opt_fg_color = self.config['opt_fg_color']
        self.char_by_char = True if self.config['char_by_char'] == 'True' else False
        self.print_speed = float(self.config['print_speed'])

    def currentTxtFgColor(self, line):
        for char in line:
                if char == '*':
                    index = line.index(char) #index of color change syntax
                    rline, color = seperateColorTag(line, index, '') #raw line and color tag are seperated and stored
                    return rline, keyDecoder(color) # returns raw line and color tag
        return line, keyDecoder(self.txt_fg_color)
    # iterates through line of text, removes color tag if there is one, then returns text output and ansi code

# Planning on having the Config class be in charge of all customization of the game, the core of the class is the config variable that calls the configure game function in initialization
config = Config()

# C:\Users\curle\Desktop\Code\Completed Projects\ChooseAdventure\Docs\Configs\Default Config.json
