class AccountBase:
    def __init__(self, overdraft):
        self._overdraft = overdraft
        self._balance = 0.0

    def deposit(self, amount):
        self._balance += amount

    def withdraw(self, amount):
        self._balance -= amount

class ATM:
    def __init__(self, account):
        self._account = account

    def withdraw_operation(self, amount):
        self._account.withdraw(amount)
