#ENTRY
if __name__ == '__main__':
    from mainLoopCtrl import readText, displayChoices, choiceChecker, pathFinder, endFlag, collectStartInfo
    from saveFeature import createSave, createSaveFlag
    from OSFuncs import clear_screen

    currentID, game, masterDict = collectStartInfo()

    while True:
        readText(currentID, masterDict)
        displayChoices(currentID, masterDict)
        choice = choiceChecker(currentID, masterDict)
        createSave(currentID, choice, game)
        currentID = pathFinder(currentID, choice, masterDict)

        if createSaveFlag(choice):
            break
        elif endFlag(choice):
            break

        clear_screen()