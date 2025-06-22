Rename to README.md

 🧠 Problem
Write a function that checks whether a given number is a **Palindrome**.

> A number is considered a palindrome if it reads the same forward and backward.

**Examples:**

Input: 121 ➞ True
Input: 12321 ➞ True
Input: 1234 ➞ False

🔍 Solutions

🐍 Python

def ReversePalindrome(Num1):
    Num2 = 0
    while (Num1 > 0):
        Remainder = Num1 % 10
        Num1 = Num1 // 10
        Num2 = Num2 * 10 + Remainder
    return Num2

def Is_Palindrome(Num1):
    return Num1 == ReversePalindrome(Num1)

⚙️ C++


int ReversePalindrome(int Num1)
   {
     int  Remainder = 0, Num2 = 0;

       while (Num1 > 0)
       {

           Remainder = Num1 % 10;
           Num1 = Num1 / 10;

           Num2 = Num2 * 10 + Remainder;

       }

       return Num2;

   }

bool Is_Palindrome(int Num1)
   {
       return Num1 == ReversePalindrome(Num1);

   }


💻 C#

 public static int ReversePalindrome(int Num1)
   {
     int  Remainder = 0, Num2 = 0;
    

       while (Num1 > 0)
       {

           Remainder = Num1 % 10;
           Num1 = Num1 / 10;

           Num2 = Num2 * 10 + Remainder;
         
       }

       return Num2;
          
   }

   public static bool Is_Palindrome(int Num1)
   {
       return Num1 == ReversePalindrome(Num1);

   }



✅ Notes
- The solution avoids converting numbers to strings, and instead uses mathematical logic.
- Part of my daily problem solving routine across three languages.

👩‍💻 By: Aziza Abdel Hamid Diab  
🔗 GitHub: https://github.com/azizadiab


