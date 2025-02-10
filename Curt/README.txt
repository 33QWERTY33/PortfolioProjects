	This is a functional Turing-complete interpreted language created in C#. There is no OOP (I don't plan to add this), and there are no lists (which I plan to add). Other than that, everything you might expect is present, for/while loops, if-elif-else conditions, variable assignments, function declarations, and a standard library. There is a REPL that starts when no arguments are provided to the executable, and a file will be parsed when passed as an argument as well. 

	The scanner is a simple loop with a switch statement that turns the characters into tokens and omits whitespace. The parser is a recursive descent parser. The AST I created takes a different approach from convention. I defined behavior inside of the nodes instead of inside of the interpreter. This way the interpreter simply identifies what statement or expression it is currently looking at and calls the related behavior. I implemented the AST nodes in this way because I wanted a data-heavy approach that could easily be serialized into an IR for the creation of an alternative interpreter with faster interpretation. The standard approach for AST nodes involves the GoF Visitor pattern as it reduces coupling and leverages dynamic polymorphic dispatch. I noticed large amounts of boilerplate for this pattern however and the logical implications of separating syntax from its behavior. This is a great approach, but it leaves room for error when implementing alternative interpreters where behavior must be redefined. (I haven't ironed out how the AST might be serialized and interpreted as an IR yet, this was my capstone project so I had a pretty tight deadline all things considered).

	The behavior of scoping in the language follows the ideas of lexical scoping, however I only separated scopes inside of a function block, everything in other blocks are still interacting directly with the global scope no matter how deeply nested. Function references are possible but closures are not currently supported as an assignment statement expects an expression to assign and scoping is currently handled through a temporary deepcopy.

	Error reporting and handling are implemented throughout all processing. There are absolutely still some bugs when the language is pushed to its limit, and I am happy to explore and patch those.


The language grammar is presented below, here you can see the operation precedence as well:

program -> statement_list

statement_list -> statement statement_list

//######################################################
// statement tree
//######################################################

statement ->
    assignment_statement
    | if_statement
    | while_statement
    | funcdef_statement
    | for_statement
    | block

funcdef_statement -> 
    ("func" | "$") IDENTIFIER "(" (IDENTIFIER)* ")" block

assignment_statement -> 
    ("make" | "~") IDENTIFIER "=" expression

if_statement -> 
    "if" "(" expression ")" block ("elif" "(" expression ")" block)* ("else" block)?

while_statement -> 
    "while" "(" expression ")" block

for_statement -> 
    "for" "(" assignment_statement ";" expression ";" expression ")" block

block -> 
    "{" statement_list "}"

//######################################################
// expression tree
//######################################################
expression -> call ;

comparison ->
    arithmetic ( (">" | ">=" | "<" | "<=" | "!=" | "==" | "and" | "or") arithmetic )* ;

arithmetic ->
    unary ( ("+" | "-" | "*" | "/" | "%") unary )* ;

unary ->
    ("not" | "-" | "++" | "--")* literal

primary -> 
    call
    | literal
    | "(" (expression)* ")" ;

call ->
    ("call" | "@")IDENTIFIER "(" (expression ("," expression)*)? ")" 

literal ->
    IDENTIFIER
    | NUMBER
    | STRING
    | BOOLEAN ;