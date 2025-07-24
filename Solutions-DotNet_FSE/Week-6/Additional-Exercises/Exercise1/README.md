# My Academy Trainers App - React Router
## Objectives

- Explain the need and benefits of React Router
- Identify Router components
- Use basic routes and links to navigate between views
- Pass URL parameters using `useParams`

---

## 🛠️ Prerequisites

Make sure the following are installed:

- Node.js
- npm
- Visual Studio Code

---

## Installation & Run

```bash
# Clone or unzip the project folder
cd TrainersApp

# Install dependencies
npm install

# Start development server
npm start
```

---

## Features
**React Router Integration**
- Uses `BrowserRouter`, `Routes`, `Route`, `Link`, and `useParams` from `react-router-dom`.

**Components Implemented**
- **Home** - Welcome page
- **TrainerList** - TrainerList 
- **TrainerDetail** - Shows trainer details by ID from URL

### Mock Data
Mock trainer data is defined in `TrainersMock.js` using a `Trainer` class model.
```js
new Trainer(
    't-syed8',
    'Syed Khaleelullah',
    'khaleelullah@cognizant.com',
    '97676516962',
    '.NET',
    ['C#', 'SQL Server', 'React', '.NET Core']
)
```

---

## Routes Configuration
| URL            | Component           | Description                           |
| -------------- | ------------------- | ------------------------------------- |
| `/`            | `Home.js`           | Default home page                     |
| `/trainers`    | `TrainerList.js`    | Displays list of all trainers         |
| `/trainer/:id` | `TrainerDetails.js` | Displays details for selected trainer |