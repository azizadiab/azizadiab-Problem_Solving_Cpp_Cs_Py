
# Day 3 – Check for Palindrome (Python | C# | C++)

## 🧠 Problem
Write a function that checks whether a given word or sentence is a **Palindrome**.

> A **Palindrome** is a string that reads the same backward as forward.  
> The check should be **case-insensitive**.

**Examples:**
```
Input: "madam"     ➞ True
Input: "RaceCar"   ➞ True
Input: "Aziza"     ➞ False
```

---

## 🔍 Solutions

### 🐍 Python
```python
def is_palindrome(text):
    text = text.lower()
    return text == text[::-1]
```

### 💻 C#
```csharp
public static bool Is_Palindrome(string text)
{
    int left = 0;
    int right = text.Length - 1;
    text = text.ToLower();

    while (left < right)
    {
        if (text[left] != text[right])
            return false;

        left++;
        right--;
    }

    return true;
}
```

### ⚙️ C++
```cpp
string LowerAll(string text)
{
    for (short i = 0; i < text.length(); i++)
        text[i] = tolower(text[i]);
    return text;
}

bool is_palindrome(string text)
{
    string stext = LowerAll(text);
    int left = 0, right = stext.length() - 1;
    while (left < right)
    {
        if (stext[left] != stext[right])
            return false;
        left++;
        right--;
    }
    return true;
}
```

---

## ✅ Notes
- This challenge strengthens your logic and understanding of string handling.
- Part of my daily cross-language problem solving series.

👩‍💻 By: Aziza Abdel Hamid Diab  
🔗 GitHub: https://github.com/azizadiab
