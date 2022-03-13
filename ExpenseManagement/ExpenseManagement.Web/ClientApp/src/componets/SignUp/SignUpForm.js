import React, { useState } from "react";

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
      secondName:enteredSecondName,
      password: enteredPassword,
      email:enteredEmail,
    };

    //ToDo send request;
    console.log(signUpRequest);
  };

  return (
    <div className="row h-100 justify-content-center align-items-center">
      <form className="w-25 p-3 " onSubmit={sumbitHandler}>
        <div className="form-group">
          {/* <label>First Name</label> */}
          <input
            type="text"
            className="form-control"
            placeholder="Enter first name"
            value={enteredFirstName}
            onChange={FirstNameChangeHandler}
          />
        </div>
        <div className="form-group">
          {/* <label>Last Name</label> */}
          <input
            type="text"
            className="form-control"
            placeholder="Enter last name"
            value={enteredSecondName}
            onChange={SecondNameChangeHandler}
          />
        </div>
        <div className="form-group">
          {/* <label>UserName</label> */}
          <input
            type="text"
            className="form-control"
            placeholder="Enter username"
            value={enteredUserName}
            onChange={UserNameChangeHandler}
          />
        </div>
        <div className="form-group">
          {/* <label>Email address</label> */}
          <input
            type="email"
            className="form-control"
            placeholder="Enter email"
            value={enteredEmail}
            onChange={EmailChangeHandler}
          />
        </div>
        <div className="form-group">
          {/* <label>Password</label> */}
          <input
            type="password"
            className="form-control"
            placeholder="Password"
            value={enteredPassword}
            onChange={PasswordChangeHandler}
          />
        </div>
        <div className="form-group form-check">
          <label>
            <a className="btn btn-primary btn-sm active" href="#" role="button">
              Terms & Conditions
            </a>
          </label>
          <input
            type="checkbox"
            className="form-check-input"
          />
        </div>
        <button type="button">
          Cancel
        </button>
        <button type="submit">Sign Up</button>
      </form>
    </div>
  );
};

export default SignUpForm;
