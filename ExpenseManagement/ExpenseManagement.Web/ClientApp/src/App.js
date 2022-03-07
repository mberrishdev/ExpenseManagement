import React, { useState } from "react";
import Expenses from "./componets/Expenses/Expenses";
import NewExpense from "./componets/NewExpense/NewExpense";

const DUMMY_EXPENSES = [
  {
    id: "e1",
    title: "Car Insurance",
    amount: 294.234,
    date: new Date(2022, 2, 6),
  },
  {
    id: "e2",
    title: "Galaxy s22",
    amount: 2100,
    date: new Date(2022, 2, 6),
  },
  {
    id: "e3",
    title: "Jetta",
    amount: 7500,
    date: new Date(2022, 1, 5),
  },
];

const App = () => {
  const [expenses, setExpenses] = useState(DUMMY_EXPENSES);
  const addExpenseHandler = (expense) => {
    setExpenses((prevExpenses) => {
      return [expense, ...prevExpenses];
    });
  };

  return (
    <div>
      <NewExpense onAddExpense={addExpenseHandler} />
      <Expenses expenses={expenses} />
    </div>
  );
};

export default App;