grammar MyGrammer;


/*
 * Lexer Rules
 */

 NUMBERS : [0-9]+ ;

 PLUS : '+' ;

 MINUS : '-' ; 

 DIV : '/' ;

 MUL : '*' ;

 LIFT : '(';

 RIGHT : ')' ; 


 SIMI : ';';

 WS : [ \n\t\r]+ -> skip;

 INVALID : . ;




/*
 * Parser Rules
 */

prog : expr SIMI EOF ;  
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
    : NUMBERS          
    | LIFT expr RIGHT  
    ;