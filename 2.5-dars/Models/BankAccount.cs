﻿namespace _2._5_dars;

public class BankAccount
{
    private string _accauntNumber;

    public string AccauntNumber
    {
        get { return _accauntNumber; }
        set { _accauntNumber = value; }
    }

    private double _balance;

    public double Balance
    {
        get { return _balance; }
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }
}
