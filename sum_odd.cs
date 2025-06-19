public static int SumOddNumbers(List<int> numbers) {
    int sum = 0;
    foreach (int number in numbers) {
        if (number % 2 == 1) sum += number;
    }
    return sum;
}

