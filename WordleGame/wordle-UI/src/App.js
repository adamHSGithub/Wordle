import { useEffect, useState } from "react";
import React from 'react';
import Wordle from "./components/Wordle";

function App() {
  const [word, setWord] = useState(null);

    useEffect(() => {

      const acquireWord = async () => {
        // Refactor code Start
        let myUrl = "https://localhost:7205/Wordle?test=a"
        let response = await fetch(myUrl);

      setWord(await response.text());
      };

      acquireWord();
  });

  return (
    <div className="App">
      <h1>Wordle</h1>
      {word && <Wordle word={word} />}
    </div>
  );
}

export default App;