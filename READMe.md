🔹 array_palindrome.cpp:
#include <iostream>
using namespace std;

bool IsPalindrome_Array(int arr[], int LengthArray)
{
    for (int i = 0; i < LengthArray / 2; i++)
    {
        if (arr[i] != arr[LengthArray - i - 1])
            return false;
    }
    return true;
}

int main()
{
    int arr[] = {1, 2, 3, 2, 1};
    int size = sizeof(arr) / sizeof(arr[0]);

    cout << (IsPalindrome_Array(arr, size) ? "Palindrome" : "Not Palindrome") << endl;

    return 0;
}

🔹 array_palindrome.cs:
using System;

class Program
{
    static bool IsPalindrome_Array(int[] array)
    {
        int LenArray = array.Length;
        for (int i = 0; i < LenArray / 2; i++)
        {
            if (array[i] != array[LenArray - i - 1])
                return false;
        }
        return true;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 1 };
        Console.WriteLine(IsPalindrome_Array(arr) ? "Palindrome" : "Not Palindrome");
    }
}

🔹 array_palindrome.py:
def is_palindrome_array(arr):
    length = len(arr)
    for i in range(length // 2):
        if arr[i] != arr[length - i - 1]:
            return False
    return True

# Test
print("Palindrome" if is_palindrome_array([1, 2, 3, 2, 1]) else "Not Palindrome")

📝 README.md:
# ✅ Day 5 - Is Array Palindrome

This challenge checks whether a given array is a palindrome — meaning it reads the same forward and backward.

## 🧠 Logic

Compare the first and last elements, then second and second-last, and so on — up to the middle of the array.

## 📌 Examples

- `[1, 2, 3, 2, 1]` → ✅ Palindrome
- `[1, 2, 3]` → ❌ Not Palindrome

## 💻 Implemented In

- C++
- C#
- Python

---

## 🔗 Author

**Aziza Diab**

GitHub: [azizadiab](https://github.com/azizadiab)




