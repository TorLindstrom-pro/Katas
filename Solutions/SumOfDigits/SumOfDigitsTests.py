import unittest

class SumOfDigits:
    @staticmethod
    def digital_root(n: int) -> int:
        string = str(n)
        while len(string) > 1:
            string = str(SumOfDigits.sum_of_digits(string))
        return int(string)

    @staticmethod
    def sum_of_digits(string) -> int:
        result = 0
        for char in string:
            result += int(char)
        return result


class MoveTenTests(unittest.TestCase):

    def test_digitalRoot_FindsRoot(self):
        self.assertEqual(SumOfDigits.digital_root(12345), 6)
    