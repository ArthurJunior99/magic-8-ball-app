import { useState } from 'react';
import './App.css';

function App() {
  const [count, setCount] = useState(0);
  const [answer, setAnswer] = useState('');
  const [loading, setLoading] = useState(false);
  const [question, setQuestion] = useState('');

  const fetchAnswer = async () => {
    if (!question.trim()) {
      setAnswer("Please enter a question.");
      return;
    }

    setLoading(true);
    setCount((prev) => prev + 1);
    try {
      const res = await fetch('http://localhost:5024/api/answers/random');
      const data = await res.json();
      setAnswer(data.text);
    } catch (error) {
      setAnswer("Couldn't get answer. Try again.");
      console.log(error)
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="app-container">
      <header className="header">
        <h1>Magic 8 Ball</h1>
      </header>

      <div className="card">
        <label htmlFor="question">Ask and I shall answer</label>
        <input
          type="text"
          id="question"
          name="question"
          placeholder="Your question..."
          value={question}
          onChange={(e) => setQuestion(e.target.value)}
        />

        <button onClick={fetchAnswer} disabled={loading}>
          {loading ? 'Thinking...' : 'Ask'}
        </button>

        <p>Questions asked: {count}</p>
        {answer && <p className="answer">{answer}</p>}
      </div>
    </div>
  );
}

export default App;
