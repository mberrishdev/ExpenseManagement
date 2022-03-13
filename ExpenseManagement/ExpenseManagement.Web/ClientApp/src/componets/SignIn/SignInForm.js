import React, { useState } from "react";
import "./SignInForm.css";
const SignInForm = (props) => {
  const [enteredUserName, setEnteredUserName] = useState("");
  const [enteredPassword, setEnteredPassword] = useState("");

  const UserNameChangeHandler = (event) => {
    setEnteredUserName(event.target.value);
  };

  const PasswordChangeHandler = (event) => {
    setEnteredPassword(event.target.value);
  };

  const sumbitHandler = (event) => {
    event.preventDefault();

    const SignInRequest = {
      userName: enteredUserName,
      password: enteredPassword,
    };

    //ToDo send request;
    console.log(SignInRequest);
  };

  return (
    <form onSubmit={sumbitHandler}>
      <div className="Sign-In__controls">
        <div className="Sign-In__input">
          {/* <label>UserName</label> */}
          <input
            type="text"
            className="form-control"
            placeholder="Enter username"
            value={enteredUserName}
            onChange={UserNameChangeHandler}
          />
        </div>
        <div className="Sign-In__input">
          {/* <label>Password</label> */}
          <input
            type="password"
            className="form-control"
            placeholder="Password"
            value={enteredPassword}
            onChange={PasswordChangeHandler}
          />
        </div>
        <p>If you don't have an account please <a href="#">Sign-Up</a>.</p>
        <button type="submit" className="btn btn-primary mb1 bg-red">Sign In</button>
        <button type="button" className="btn btn-primary mb1 bg-blue">Cancel</button>
      </div>
    </form>
  );
};

export default SignInForm;
