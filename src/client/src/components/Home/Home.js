import { useState, useEffect } from 'react';

function Home() {
    const [data, setData] = useState(null);

    useEffect(() => {
        fetch('http://localhost:5500/home')
            .then(response => response.json())
            .then(data => setData(data))
            .catch(error => console.error(error));
    }, []);

    return (
        <>
            <h1>This is my home page brother</h1>
            <h2>What should I do next</h2>
            <div>
                {data ? (
                    data.map(item => (
                        <div key={item.id}>
                            <h3>{item.name}</h3>
                            <p>{item.description}</p>
                        </div>
                    ))
                ) : (
                    <div>Loading...</div>
                )}
            </div>
        </>
    );
}

export default Home;
