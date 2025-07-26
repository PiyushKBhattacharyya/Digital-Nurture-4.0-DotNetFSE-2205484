# Shopping App - Props, React Router DOM
##  Objectives
- Define Props in React.
- Explain Default Props and how they work.
- Understand the difference between State and Props.
- Explain how `ReactDOM.render()` works.
- Use Props in Class Components to pass and display data.
- Apply `ReactDOM.render()` to mount the main component to the DOM.

---

## Prerequisites
Before you begin, make sure you have the following installed:
- Node.js
- NPM (comes with Node.js)
- Visual Studio Code

---

## Implementation
### **1. Create a React Application**

```bash
npx create-react-app shoppingapp
cd shoppingapp
```

### **2. Create Class Components**
Inside the `src/` directory, create two files:
- `OnlineShopping.js`
- `Cart.js`

### **3. Define Cart Class Component**
```jsx
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
```

### **4. Define `OnlineShopping` Class Component**
```jsx
import React from 'react';
import Cart from './Cart';
import './stylesheet/stylesheet.css';

class OnlineShopping extends React.Component {
  render() {
    const CartInfo = [
      { itemname: "Laptop", price: 80000 },
      { itemname: "TV", price: 120000 },
      { itemname: "Washing Machine", price: 50000 },
      { itemname: "Mobile", price: 30000 },
      { itemname: "Fridge", price: 70000 }
    ];
    return (
      <div className="shop-bg">
        <h1 className="cart-heading">Items Ordered :</h1>
        <Cart item={CartInfo} />
      </div>
    );
  }
}

export default OnlineShopping;
```

### **5. Start development server**
```bash
npm start
```