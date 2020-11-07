Бібліотека для роботи з IEnumerable<T>.
        
       Для чого бібліотека?
       
            Для удобного написання не блокуючого кода, тоїсть коли є 10 потоків і один ресурс.
       
       Які функції є в бібліотеці?
       
	        1)Розділення масива на частини, де вхідні дані це кількість частин в масиві.(Метод Split,SplitLazy)
        
	        2)Множення масива на n кількість частин(метод Multiplication,MultiplicationLazy)
        
        	3)Віднімання n кількість елементів в масиві(метод Subtract,SubtractLazy)
        
	        4)Додавання n кількість частин(метод Addition,AdditionLazy)
В бібліотеці є два типи методів обичні , без закінчення Lazy, і з закіченням Lazy.Якщо не потрібна безопасність в многопоточності луче використовувати Lazy.
	
	Приклади коду.
	       var result = Enumerable.Range(0, 10)
                .Select(x => x.ToString())
                .AdditionLazy(2)
		.MultiplicationLazy(2)
		.SplitLazy(3)
		.SubtractLazy(1);
		
		
