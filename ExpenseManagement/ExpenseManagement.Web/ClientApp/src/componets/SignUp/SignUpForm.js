import React, { useState } from "react";
import "./SignUpForm.css";
const SignUpForm = (props) => {
  const [enteredFirstName, setEnteredFirstName] = useState("");
  const [enteredSecondName, setEnteredSecondName] = useState("");
  const [enteredUserName, setEnteredUserName] = useState("");
  const [enteredEmail, setEnteredEmail] = useState("");
  const [enteredPassword, setEnteredPassword] = useState("");

  const FirstNameChangeHandler = (event) => {
    setEnteredFirstName(event.target.value);
  };

  const SecondNameChangeHandler = (event) => {
    setEnteredSecondName(event.target.value);
  };

  const UserNameChangeHandler = (event) => {
    setEnteredUserName(event.target.value);
  };

  const EmailChangeHandler = (event) => {
    setEnteredEmail(event.target.value);
  };

  const PasswordChangeHandler = (event) => {
    setEnteredPassword(event.target.value);
  };

  const sumbitHandler = (event) => {
    event.preventDefault();

    const signUpRequest = {
      userName: enteredUserName,
      firstName: enteredFirstName,
      secondName: enteredSecondName,
      password: enteredPassword,
      email: enteredEmail,
    };

    //ToDo send request;
    console.log(signUpRequest);
  };

  return (
    <form onSubmit={sumbitHandler}>
      <div className="sign-Up__controls">
        <div className="sign-Up__input">
          <input
            type="text"
            className="form-control"
            placeholder="Enter first name"
            value={enteredFirstName}
            onChange={FirstNameChangeHandler}
          />
        </div>
        <div className="sign-Up__input">
          {/* <label>Last Name</label> */}
          <input
            type="text"
            className="form-control"
            placeholder="Enter last name"
            value={enteredSecondName}
            onChange={SecondNameChangeHandler}
          />
        </div>
        <div className="sign-Up__input">
          {/* <label>UserName</label> */}
          <input
            type="text"
            className="form-control"
            placeholder="Enter username"
            value={enteredUserName}
            onChange={UserNameChangeHandler}
          />
        </div>
        <div className="sign-Up__input">
          {/* <label>Email address</label> */}
          <input
            type="email"
            className="form-control"
            placeholder="Enter email"
            value={enteredEmail}
            onChange={EmailChangeHandler}
          />
        </div>
        <div className="sign-Up__input">
          {/* <label>Password</label> */}
          <input
            type="password"
            className="form-control"
            placeholder="Password"
            value={enteredPassword}
            onChange={PasswordChangeHandler}
          />
        </div>
        <p>If you already have an account please <a href="#">Sign-In</a>.</p>
        <button type="submit" className="btn btn-primary mb1 bg-red">Sign Up</button>
        <button type="button" className="btn btn-primary mb1 bg-blue">Cancel</button>
      </div>
    </form>
  );
};

export default SignUpForm;
