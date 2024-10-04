import unittest
from Move10 import Move10

class MoveTenTests(unittest.TestCase):
    
    def test_moveTen_movesSingleLetter10Chars(self):
        self.assertEqual(Move10.move_ten("a"), "k")
        
    def test_moveTen_movesLetter10Chars(self):
        self.assertEqual(Move10.move_ten("testcase"), "docdmkco")