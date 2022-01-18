using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Tutorials
{

   class Basics
   {
      static void Main(string[] args){
         bool stillPlaying = true;
         Random number = new Random();
         int numberOFGuess = 0;
         System.Console.WriteLine("Welcome to console guessess");
         System.Console.WriteLine("guess the right number and you win");
         while(stillPlaying == true){
            System.Console.WriteLine("guess a number from one to 0ne hundred");
            Console.Write("enter your guess: ");
            int guess = getGuess();
            System.Console.WriteLine(guess);
            //if(){

            //}
            stillPlaying = false;
         }

      }
      static int getGuess(){
         int getNum = 0;
          try{
            getNum = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ){
               Console.Write("Please enter only numbers: ");
               getNum = getGuess();
            }
            return getNum;

      }
   }
}