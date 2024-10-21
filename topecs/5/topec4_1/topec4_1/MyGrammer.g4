grammar MyGrammer;




program
    : 'Start' statement* 'End'
    ;


statement
    : variableDeclaration
    | ifStatement
    | printStatement
    | block
    ;


variableDeclaration
    : 'int' variable (',' variable)* ';'
    ;

variable
    : IDENTIFIER ('=' expr)?   
    ;


ifStatement
    : 'if' '(' comparisonExpression ')' block ( elseStat )?
    ;

elseStat : 'else' block;

block
    : '{' statement* '}'
    ;


printStatement
    : 'print' '(' expr ')' ';'
    ;


comparisonExpression
    : expr (LT | GT | AQU | NOTAQU) expr
    ;


expr
    : expr PLUS term  
    | expr MINUS term 
    | term            
    ;

term
    : term MUL factor  
    | term DIV factor  
    | factor           
    ;

factor
    : NUMBER             
    | LIFT expr RIGHT     
    | IDENTIFIER       
    ;


PLUS : '+' ;
MINUS : '-' ;
MUL : '*' ;
DIV : '/' ;

LIFT : '(';
RIGHT : ')';

LT : '<' ;

GT : '>' ;
AQU  : '==' ;
NOTAQU : '!=' ;

NUMBER
    : [0-9]+
    ;

IDENTIFIER
    : [a-zA-Z_][a-zA-Z0-9_]*
    ;


WS
    : [ \t\r\n]+ -> skip
    ;