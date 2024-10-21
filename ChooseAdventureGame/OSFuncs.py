import os

def clear_screen():
    # Check if the OS is Windows
    if os.name == 'nt':
        os.system('cls')
    else:
        # For Linux and macOS
        os.system('clear')
# Uses the cls command to clear the screen on each loop
def list_files(path):
    return {str(num): file for num, file in enumerate(os.listdir(path))}
# returns a list of all of the files in the specified directory