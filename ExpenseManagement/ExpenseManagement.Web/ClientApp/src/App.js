//import React, { useState } from "react";
//import Expenses from "./componets/Expenses/Expenses";
//import NewExpense from "./componets/NewExpense/NewExpense";
import SignUpForm from "./componets/SignUp/SignUpForm";
import SignInForm from "./componets/SignIn/SignInForm";

import 'bootstrap/dist/css/bootstrap.min.css';

// const DUMMY_EXPENSES = [
//   {
//     id: "e1",
//     title: "Car Insurance",
//     amount: 294.234,
//     date: new Date(2022, 2, 6),
//   },
//   {
//     id: "e2",
//     title: "Galaxy s22",
//     amount: 2100,
//     date: new Date(2022, 2, 6),
//   },
//   {
//     id: "e3",
//     title: "Jetta",
//     amount: 7500,
//     date: new Date(2022, 1, 5),
//   },
// ];

const App = () => {
  // const [expenses, setExpenses] = useState(DUMMY_EXPENSES);
  // const addExpenseHandler = (expense) => {
  //   setExpenses((prevExpenses) => {
  //     return [expense, ...prevExpenses];
  //   });
  // };

  return (
    <div>
      {/* <SignUpForm></SignUpForm> */}
      <SignInForm></SignInForm>
      {/* <NewExpense onAddExpense={addExpenseHandler} />
      <Expenses expenses={expenses} /> */}
    </div>
  );
};

export default App;
