# Members


|   	   .		|    própria class 	|   subclasses no assembly	| 	classes do assemply	|  subclasses fora do assembly	| classes fora do assembly	|
|  	  ---		|	---		|	     ---		|	       ---		|	     ---		|	    ---			|
| public 		| 	 x		|	      x			|		x		|	      x			|	     x			|
| protected internal 	| 	 x		|	      x			|		x		|	      x			|				|
| internal		|	 x		|	      x			|		x		|	      			|				|
| protected		|	 x		|	      x			|				|	      x			|				|
| private protected	|	 x		|	      x			|				|	      			|				|
| private	    	|	 x		|	      			|				|	      			|				|

## Classes

- Acesso por qualquer classe
  - public class Product

- Acesso somente dentro do assembly
  - internal class Product
  - class Product

- Acesso somente pela classe-mãe
  - private class Product
  - Nota: classe aninhada, por padrão, é private
