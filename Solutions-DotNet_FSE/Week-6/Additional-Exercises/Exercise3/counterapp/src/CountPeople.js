import React, { Component } from 'react';
import './Sylesheet/CountPeople.css';

class CountPeople extends Component {
  constructor(props) {
    super(props);
    this.state = {
      entrycount: 0,
      exitcount: 0,
    };
  }

  UpdateEntry = () => {
    this.setState({
      entrycount: this.state.entrycount + 1,
    });
  };

  UpdateExit = () => {
    this.setState({
      exitcount: this.state.exitcount + 1,
    });
  };

  render() {
    return (
      <div className="container">
        <h2 className="title">People Counter</h2>
        <p className="label">{this.state.entrycount} People Entered!!!</p>
        <p className="label">{this.state.exitcount} People Exited: </p>
        <div className="button-group">
          <button className="btn" onClick={this.UpdateEntry}>Login</button>
          <button className="btn" onClick={this.UpdateExit}>Exit</button>
        </div>
      </div>
    );
  }
}

export default CountPeople;