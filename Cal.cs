using System;

namespace Calapp {
 class Data {
     double n1;
     double n2;
     int s;
     double res;
    public void display() {
         Console.WriteLine("Enter the First number : ");
         n1 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter the Second number : ");
         n2 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Choose an Arithmetic Opertation -  \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division \n 5. Modulus");
         s = Convert.ToInt32(Console.ReadLine());
     }
     public double calculate() {
        if (s==1){
            res = n1+n2;
        }
        else if(s==2){
            res = n1-n2;
        }
        else if(s==3){
            res = n1*n2;
        }
        else if(s==4){
            res = n1/n2;
        }
        else if(s==5){
            res = n1%n2;
        }
        return res;
     }
     public void result(){
         Console.WriteLine("Result = {0}", calculate());
     }
 }
 class Calculator {
     static void Main(String[] args){
         Data d = new Data();
         d.display();
         d.result();
         Console.ReadKey();
     }
 }
}