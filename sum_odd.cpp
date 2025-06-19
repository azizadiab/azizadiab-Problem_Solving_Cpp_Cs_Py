int sumOddNumbers(const vector<int>& numbers) {
    int sum = 0;
    for (int num : numbers) {
        if (num % 2 == 1) sum += num;
    }
    return sum;
}

