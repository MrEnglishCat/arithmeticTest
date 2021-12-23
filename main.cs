using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
public static void Main()
{
  Random random = new Random();
   int firstValue = 0, secondValue = 0, resultValue = 0, userResultValue = 0;         
   string quit = "",
          change = "",
          checkAll = "change";
   char userAction = ' ';
   double  persentCheckTrueTotalTest = 0,
           persentCheckFalseTotalTest = 0;
   uint endFirstCycle = 0,         
        checkTrueCurrentTest = 0,
        checkFalseCurrentTest = 0, 
 
        checkTrueTotalTest = 0,
        checkFalseTotalTest = 0,      
 
        totalQuiestionsCurrentTest = 0,
 
        totalQuestions = 0,
       
        totalQuestionsPlus = 0,
        totalQuestionsMinus = 0,
        totalQuestionsMultiply = 0,
        totalQuestionsDivision = 0;
 
// MAIN CYCLE
   while ( quit != "quit" )
   { 
       // ДЕЛЕНИЕ ПОКА ЧТО ПРАВИЛЬНО НЕ РАБОТАЕТ, пока что все переменные int
 
     switch (checkAll)
     {
       case "change":
               if (endFirstCycle == 1)
               {   
                   Console.WriteLine ($@"Выберите действие, которые хотите проверить:
                   +; -; *; /.
          
           На выбранное действие будет предложена проверка по соответствующей таблице.");
                   Console.WriteLine();
                   endFirstCycle = 0;
                   totalQuiestionsCurrentTest = 0;
                   checkTrueCurrentTest = 0;
                   checkFalseCurrentTest = 0;
                   userAction = char.Parse(Console.ReadLine());       
               }
               else
               {
                   if (endFirstCycle == 1)
                   {
                   endFirstCycle = 0;        
                   }      
                   // выполняется если не введено change, так же выполняется самый 1й вход в цикл while
                   else
                   {
                       Console.WriteLine($@"Управление программой:
                       change - для смены выполняемой операции (+; -; *; /);
                       total - для просмотра результатов;
                       help - справка по возможным командам управления;
                       quit - для завершения программы.");
                       Console.WriteLine();
                       Console.WriteLine ($@"Выберите действие, которые хотите проверить:
                       +; -; *; /.
           На выбранное действие будет предложена проверка по соответствующей таблице.");
                       Console.WriteLine();           
                       userAction = char.Parse(Console.ReadLine());
                   }
               }
           break;
       case "total":
               Console.WriteLine($@"Всего вопросов: {totalQuestions}.");
               Console.WriteLine($@"   %-т ВСЕХ верных ответов: {persentCheckTrueTotalTest}.");
               Console.WriteLine($@"   %-т ВСЕХ НЕверных ответов: {persentCheckFalseTotalTest}.");
               Console.WriteLine($@"Всего вопросов на {userAction}-ие: {totalQuiestionsCurrentTest}.");       
               Console.WriteLine($@"   Верных ответов : {checkTrueCurrentTest}.");
               Console.WriteLine($@"   Неверных ответов: {checkFalseCurrentTest}.");
               Console.WriteLine($@"Нажмите Enter для продолжения выполнения теста на выбранную операцию "); 
               Console.ReadLine();
           break;
       case "help":
           Console.WriteLine($@"Управление программой:
                       change - для смены выполняемой операции (+; -; *; /);
                       total - для просмотра результатов;
                       quit - для завершения программы.");
            Console.WriteLine($@"Нажмите Enter для продолжения выполнения теста на выбранную операцию "); 
               Console.ReadLine();
           break;
     }
    
    // OUTPUT TOTAL STATISTICS    
     
     firstValue = random.Next(1,11);
     secondValue = random.Next(1,11);
   
     Console.Write($@"Введите результат выбранного действия: {firstValue} {userAction} {secondValue} = ");     
     userResultValue = int.Parse(Console.ReadLine());
     Console.WriteLine();
    
     switch (userAction)
     {
       case '+':
        resultValue = firstValue + secondValue;
        totalQuestionsPlus++;
        break;
       case '-':        
        resultValue = firstValue - secondValue;
        totalQuestionsMinus++;
        break;
       case '*':        
        resultValue = firstValue * secondValue;
        totalQuestionsMultiply++;
        break;
       case '/':
        resultValue = firstValue / secondValue;
        totalQuestionsDivision++;
        break;
     }
 
    if (resultValue == userResultValue)
    {
      Console.WriteLine ($"Вы ответили ВЕРНО!");
      Console.WriteLine();
      Console.WriteLine("Нажмите любую клавишу для выполнения следующей тренировки по той же операции. Или введите одну из команд управления(change, total, quit)");
      checkTrueCurrentTest ++;
      checkTrueTotalTest++;
    }
    else
    {
      Console.WriteLine ($"Вы ответили НЕ верно! Верный результат {resultValue}");
      Console.WriteLine();
      Console.WriteLine("Нажмите любую клавишу для выполнения следующей тренировки по той же операции. Или введите одну из команд управления(change, total, quit)");
      checkFalseCurrentTest++;
      checkFalseTotalTest++;
    }
       quit = Console.ReadLine ();
       Console.WriteLine();
       change = quit;
       checkAll = quit;
       endFirstCycle = 1;
 
       totalQuestions++;
 
       totalQuiestionsCurrentTest = checkFalseCurrentTest + checkTrueCurrentTest;
 
       persentCheckTrueTotalTest =checkTrueTotalTest * 100 / totalQuestions;
       persentCheckFalseTotalTest = checkFalseTotalTest * 100 / totalQuestions;
      
   }
 }
}