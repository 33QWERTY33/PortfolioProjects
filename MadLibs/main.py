'''
when creating a madlibs file to be processed by this program, you should place every word you want inside within <> brackets 
'''


def open_file(file_name):
    '''
    opens the madlibs file
    param: file_name = name of the file
    return: line_list = list of lines from the file
    '''
    line_list = []
    with open(file_name, "r") as file:
        for line in file:
            line_list.append(line)
            # open the file using the file_name argument
        return line_list


def find_delims(line_list):
    '''
    finds the delimeters and stores the indexes, and string in lists
    param: line_list = list of lines from the file
    return: delim_id_list = list of delimeter identification, delim_idx_list = list of delimeter indexes, line_list = list of lines from file
    '''
    delim_idx_list = []
    delim_id_list = []
    # list vars
    count = 0
    # count what character the iterator is on in the current line to allow for selecting multiple delimeters in the same line
    for line in line_list:
        for char in line:
            if char == "<":
                start = line.index(char, count-1)
                # start var = index of "<"
            if char == '>':
                end = line.index(char, count-1)
                # end var = index of ">"
                delim_idx_list.append((start, end))
                delim_id_list.append(line[start:end+1])
                # append delim index to idx list, and id to id list
            count += 1
        count = 0
    return delim_id_list, delim_idx_list, line_list


def gather_input(delim_id_list, delim_idx_list, line_list):
    '''
    gathers input for each delimeter in the text file
    params: delim_id_list = list of delimeter identification, delim_idx_list = list of delimeter indexes, line_list = list of lines from file
    return: word_list = list of words to replace delimeters with, line_list = list of lines from file
    '''
    word_list = []
    for delim in zip(delim_id_list, delim_idx_list):
        # zipping lists together
        word_list.append(input(f"Enter a {delim[0][1:-1]} >> "))
        # append new word
    return word_list, line_list


def replace_delim_w_word(word_list, line_list):
    '''
    replaces the delimeters with the new words
    params: word_list = list of words to replace delimeters with, line_list = list of lines from file
    return: new_string = The updated string to be written to the new file 
    '''
    exempt = False
    # controls whether it adds characters or not
    count = 0
    # controls what word it adds to the new string
    new_string = ""
    for line in line_list:
        for char in line:
            if char == "<":
                new_string += word_list[count]
                # add new word to new_string
                count += 1
                # next word
                exempt = True
                # don't add characters to new_line
            elif char == ">":
                exempt = False
                # being adding characters to new_line again
            elif not exempt:
                new_string += char
                # add the character to the new_line
    return new_string

def view_result(yesno, file_name):
    '''
    takes a yes or a no to viewing file, if yes, displays file
    params: yesno = a string response to the question "Would you like to see the result [y/n]", file_name = name of the new file
    return: N/A
    '''
    if yesno == "y":
        with open(file_name, "r") as file:
            print()
            for line in file:
                print(line, end='')
        # if yes print each line
    

def main():
    new_string = replace_delim_w_word(*gather_input( \
        *find_delims(open_file(input("Enter the file name: ")))))
    # open_file then find delimeters then gather input then replace delimeters with words then store result in new_string var
    new_file_name = input("what is the name of the new file you want to create:")
    # name of the new file
    new_file = open(new_file_name, "w")
    # open new file
    new_file.write(new_string)
    # write string to new file
    new_file.close()
    # close new file
    view = input("Would you like to see the result [y/n] ")
    # view or not
    view_result(view, new_file_name)
    # handle view results


if __name__ == "__main__":
    main()
