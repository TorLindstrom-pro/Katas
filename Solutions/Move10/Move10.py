class Move10:
    @staticmethod
    def move_ten(text: str) -> str:
        return str.translate(text, str.maketrans("abcdefghijklmnopqrstuvwxyz", "klmnopqrstuvwxyzabcdefghij"))