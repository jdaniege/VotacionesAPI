// Importa axios para hacer peticiones HTTP
import axios from "axios";

// URL base de la API de votos
const API = "http://localhost:5000/api/votos";

// Obtiene la lista de votos (GET)
export const getVotos = () => axios.get(API);
// Crea un nuevo voto (POST)
export const crearVoto = (voto) => axios.post(API, voto);