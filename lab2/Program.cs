using lab2;

BankAccount bankAccount = new BankAccount("Nikodem","Szubierski", 1m);
bankAccount.view();

bankAccount.wplata(100);
bankAccount.view();
bankAccount.wyplata(50);
bankAccount.view();