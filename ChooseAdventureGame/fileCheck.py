if __name__ == '__main__':
    from txtProcessing import textSerializer, dictPrep, ctrlData, txtContents
    def policeman():
        displayCount = 0        # Used to count the index of the display data
        ctrlCount = 0           # Used to count the index of the control data
        errorCount = 0          # Used to count the number of errors
        for i in ctrlData:
            ctrlCount += 1
            if i[0] != '$' or i[-1] != ';':         # if the first char isn't $ or the last char isn't ; add to error count and print line info
                errorCount += 1
                print(f'There is incorrect placement of characters on line {ctrlCount}, the line is: {i}')
        for i in txtContents:
            displayCount += 1
            if ('[' not in i) or (']'not in i):     # if there aren't [] chars in the display data list, add to error count, and print line info
                errorCount += 1
                print(f'There is incorrect placement of characters on entry {i}')

        print(f'out of {ctrlCount} lines, I found {errorCount} syntax errors')
    # policeMan func goes through each line and looks for syntax errors, if an error is found it prints it and the index it can be found at.
    file = input('What is the file you are looking to check? ')
    # input file name
    textSerializer(file)
    dictPrep(txtContents)
    policeman()