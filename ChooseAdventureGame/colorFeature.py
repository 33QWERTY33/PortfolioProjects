import sys
ansi = {
        'R': '\x1b[38;5;9m',
        'O': '\x1b[38;5;214m',
        'Y': '\x1b[38;5;226m',
        'G': '\x1b[38;5;28m',
        'B': '\x1b[38;5;12m',
        'I': '\x1b[38;5;134m',
        'V': '\x1b[38;5;201m',
        'NormFG': '	\x1b[\x1b[38;5;255m',
        'NormBG': '\x1b[38;5;0m'
}

def defaulter():
    print(f'{ansi["NormFG"]}', end = '', sep = '', file = sys.stderr)
# defaulter returns text output to the normal colors
def cprint(txt = '', fg_color = ansi['NormFG'], end = '\n'):
    print(f"{fg_color}{txt}", end = end, flush = True)
    defaulter()
# cprint is intended to be used with a dictionary holding parameters, and the unpacking syntax passed as an arg
def keyDecoder(color):
    ansiCode = ansi[color]
    return ansiCode
# Key Decoder converts the value that is stored in the config file to the correct ansi code