// Importa los hooks useEffect y useState de React
import { useEffect, useState } from "react";
// Importa las funciones para interactuar con la API
import { getVotos, crearVoto } from "./services/api";

function App() {
  // Estado para almacenar la lista de votos
  const [votos, setVotos] = useState([]);
  // Estado para el nombre del candidato
  const [candidato, setCandidato] = useState("");
  // Estado para la cédula
  const [cedula, setCedula] = useState("");

  // Función para cargar los votos desde la API
  const cargarVotos = async () => {
    const res = await getVotos(); // Llama a la API para obtener los votos
    setVotos(res.data); // Actualiza el estado con los votos recibidos
  };

  // Función para enviar un voto a la API
  const votar = async () => {
    await crearVoto({ candidato, cedula }); // Envía el voto a la API
    setCandidato(""); // Limpia el campo de candidato
    setCedula(""); // Limpia el campo de cédula
    cargarVotos(); // Recarga la lista de votos
  };

  // useEffect se ejecuta una vez al montar el componente para cargar los votos
  useEffect(() => {
    cargarVotos();
  }, []);

  return (
    <div style={{ padding: "20px" }}>
      <h1>Votaciones</h1>

      {/* Input para el nombre del candidato */}
      <input
        value={candidato}
        onChange={(e) => setCandidato(e.target.value)}
        placeholder="Nombre del candidato"
      />
      {/* Input para la cédula */}
      <input
        value={cedula}
        onChange={(e) => setCedula(e.target.value)}
        placeholder="Cédula"
      />
      {/* Botón para votar */}
      <button onClick={votar}>Votar</button>

      {/* Lista de votos */}
      <ul>
        {votos.map((v) => (
          <li key={v.id}>{v.candidato} - {v.cedula}</li>
        ))}
      </ul>
    </div>
  );
}

export default App;