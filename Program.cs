// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Request {
    
    public static void HandleRequest() {
        int a, b;
        var chek = true;
    while(chek){
    try{
        Console.Write("Введите 1 число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, / , c -сбросить,q-выйти): ");
        string operation = Console.ReadLine();

        var result = 0;
        switch (operation) {
            case "+":
            try{
                result = Calc.Add(a, b);
                Console.WriteLine($"Сложение: {result}");
            }
            catch(ArgumentOutOfRangeException ex){
                Console.WriteLine("err:"+ ex);
            }
                break;
            case "-":
            try{
                result = Calc.Subtract(a, b);
                Console.WriteLine($"Вычитание: {result}");
            }
             catch(ArgumentOutOfRangeException ex){
                Console.WriteLine("err:"+ ex);
            }
                break;
            case "*":
            try{
                result = Calc.Multiply(a, b);
                Console.WriteLine($"Умножение: {result}");
            }
             catch(ArgumentOutOfRangeException ex){
                Console.WriteLine("err:"+ ex);
            }
                break;
            case "/":
            try{
                double quotient = Calc.Divide(a, b);
                Console.WriteLine($"Деление: {quotient}");
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("error"+ex);
                break;
            }
             catch(ArgumentOutOfRangeException ex){
                Console.WriteLine("err:"+ ex);
            }
                break;
            default:
                Console.WriteLine("операция не найдена");
                break;
            case "c":
            Console.WriteLine("Значение"+result);
            break;
            case"q":
            chek = false;
            Console.WriteLine("Bye");
            break;
        }
    }
    catch(OverflowException ex){
        Console.WriteLine("err"+ex);
    }
    catch{
        chek=false;
        break;
    }
        

        
    }
    }
    }