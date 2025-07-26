import React from 'react';
import './stylesheet/stylesheet.css';

class Cart extends React.Component {
  render() {
    return (
      <div className="cart-outer-box">
        <table className="cart-table">
          <thead>
            <tr>
              <th className="cart-header">Name</th>
              <th className="cart-header">Price</th>
            </tr>
          </thead>
          <tbody>
            {this.props.item.map((item, idx) => (
              <tr key={idx}>
                <td className="cart-cell">{item.itemname}</td>
                <td className="cart-cell">{item.price}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  }
}

export default Cart;