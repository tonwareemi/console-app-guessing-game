using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Tutorials
{

   class Basics
   {
      static bool stillPlaying = true;
      static void Main(string[] args){
         
         Random number = new Random();
         int numberOFGuess = 0;
         int numberOfTimesPlayed = 0;
         System.Console.WriteLine("Welcome to console guessess");
         System.Console.WriteLine("guess the right number and you win");
         while(stillPlaying == true){
            System.Console.WriteLine("guess a number from one to 0ne hundred");
            int guess = 0;
            //System.Console.WriteLine(guess);
            int win = number.Next(1,101);
            while(guess != win){
               guess = getGuess();
               if(guess == win){
               System.Console.WriteLine("you win");
               System.Console.WriteLine($"your number of guesses are: {numberOFGuess} ");
               numberOfTimesPlayed++;
            }else if (guess > win){
               System.Console.WriteLine("guess to high");
               numberOFGuess++;
            }else if(guess < win){
               System.Console.WriteLine("guess to low");
               numberOFGuess++;
            }
            }
            System.Console.Write("Do you want to play again ? (Yes/No): ");
            stillPlay();
         }

      }
      static int getGuess(){
         int getNum = 0;

            Console.Write("enter your guess: ");
          try{
            getNum = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ){
               Console.WriteLine("Please enter only numbers");
               getNum = getGuess();
            }
            return getNum;

      }

      static void stillPlay (){
         string tryAgain = Console.ReadLine();
          switch(tryAgain.ToLower()){
               case "yes":
               break;
               case "no":
               stillPlaying = false;
               break;
               default:
               System.Console.Write("enter yes or no: ");
               stillPlay();
               break;
            }
      }
   }
}