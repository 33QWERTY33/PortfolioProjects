# Made some time in early 2022

'''The program should open a specified text file, read its contents, 
then use the dictionary to write an encrypted version of the file's contents to a second file. 
Each character in the second file should contain the code for the corresponding character in the first file.
Write a second program that opens an encrypted file and displays the decrypted contents on the screen'''

if __name__ == '__main__':
    message = input('Enter the name of the file that stores the message you want to unencrypt: ')
    unencrypted_message = ''
    encrypted = open(message, 'r')
    codes = {'A': '!','a': '@','B': '#','b': '$','C': '%','c': '^','D': '&','d': '*','E': '(','e': ')','F': '1','f': '2','G': '3','g': '4','H': '5',
             'h': '6','I': '7','i': '8', 'J': '9','j': '0','K': 'Q','k': 'q','L': 'W','l':'w','M': 'E','m': 'e','N': 'R','n': 'r','O': 'T','o': 't',
             'P': 'Y','p': 'y','Q': 'U','q': 'u','R': 'I','r': 'i', 'S': 'O','s': 'o','T': 'P','t': 'p', 'U': 'A','u': 'a','V': 'S','v': 's','W': 'D',
             'w': 'd','X': 'F','x': 'f','Y': 'G','y': 'g','Z': 'H','z': 'h','1': 'J','2': 'j','3': 'K','4': 'k','5': 'L','6': 'l','7': 'Z','8': 'z',
             '9': 'X','0': 'x', '!': 'C',"@": 'c', '#': 'V','$': 'v','%': 'B','^': 'b','&': 'N','*': 'n','(': 'M', ')': 'm', ',': '<','<': ',', '.': '>',
             '>': '.', '/': '?','?': '/', ':': ';',';': ':',"'": '"', '"': "'", '[': '{', '{': '[', ']': '}', '}': ']', '\\': '|','|': '\\', '-': '_',
             '_': '-','+': '=','=': '+',' ': '~'}
    
    code_keys = codes.keys()
    
    decoder = {}
    for x in code_keys:
        transition = {codes[x]:x}
        decoder.update(transition)
    
    for line in encrypted.readlines():
        for char in line:
            if char in decoder:
                unencrypted_message += decoder[char]
            else:
                unencrypted_message += char
    
    unencrypted = open('Un' + message, 'w')
    unencrypted.write(unencrypted_message)
    
    encrypted.close()
    unencrypted.close()