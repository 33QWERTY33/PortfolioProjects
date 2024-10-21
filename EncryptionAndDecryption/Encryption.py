# Made some time in early 2022

'''The program should open a specified text file, read its contents, 
then use the dictionary to write an encrypted version of the file's contents to a second file. 
Each character in the second file should contain the code for the corresponding character in the first file.
Write a second program that opens an encrypted file and displays the decrypted contents on the screen'''
name = '__main__'
if name == '__main__':
    message = input('Enter the name of the file that stores the message you want to encrypt: ')
    encrypted_message = ''
    unencrypted = open(message, 'r')
    codes = {'A': '!','a': '@','B': '#','b': '$','C': '%','c': '^','D': '&','d': '*','E': '(','e': ')','F': '1','f': '2','G': '3','g': '4','H': '5',
             'h': '6','I': '7','i': '8', 'J': '9','j': '0','K': 'Q','k': 'q','L': 'W','l':'w','M': 'E','m': 'e','N': 'R','n': 'r','O': 'T','o': 't',
             'P': 'Y','p': 'y','Q': 'U','q': 'u','R': 'I','r': 'i', 'S': 'O','s': 'o','T': 'P','t': 'p', 'U': 'A','u': 'a','V': 'S','v': 's','W': 'D',
             'w': 'd','X': 'F','x': 'f','Y': 'G','y': 'g','Z': 'H','z': 'h','1': 'J','2': 'j','3': 'K','4': 'k','5': 'L','6': 'l','7': 'Z','8': 'z',
             '9': 'X','0': 'x', '!': 'C',"@": 'c', '#': 'V','$': 'v','%': 'B','^': 'b','&': 'N','*': 'n','(': 'M', ')': 'm', ',': '<','<': ',', '.': '>',
             '>': '.', '/': '?','?': '/', ':': ';',';': ':',"'": '"', '"': "'", '[': '{', '{': '[', ']': '}', '}': ']', '\\': '|','|': '\\', '-': '_',
             '_': '-','+': '=','=': '+',' ': '~'}
    
    for line in unencrypted.readlines():
        for char in line:
            if char in codes:
                encrypted_message += codes[char]
            else:
                encrypted_message += char   
    
    encrypted = open('Encrypted' + message, 'w')
    encrypted.write(encrypted_message)
    
    encrypted.close()
    unencrypted.close()