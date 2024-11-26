import axios from "axios";
import { useState } from "react";

function TarefaAlterar() {
  const [tarefaId, setTarefaId] = useState("");
  const [status, setStatus] = useState("");

  function alterarTarefa(event : any) {
    event.preventDefault();
    const tarefaAtualizada = {
      tarefaId,
      status,
    }
    axios.patch(`http://localhost:5000/api/tarefas/alterar/${tarefaId}`, tarefaAtualizada, {
      headers: {
        'Content-Type' : 'application/json',
      },
    })
    .then((response) => {
      console.log(response.data);
    })
    .catch((error) => {
      console.log("Erro ao alterar produto: " + error);
    })
  }

  return(
    <div>
      <h1>Alterar tarefa</h1>
      <form onSubmit={alterarTarefa}>
        <div>
          <label>Tarefa ID</label>
          <input
            type="text"
            value={tarefaId}
            onChange={(e) => setTarefaId(e.target.value)}
            required>
          </input>
        </div>
        <div>
          <label>Status</label>
          <input
            type="text"
            value={status}
            onChange={(e) => setStatus(e.target.value)}
            required>
          </input>
        </div>
        <div>
          <button type="submit">Salvar</button>
        </div>
      </form>
    </div>
  )
}

export default TarefaAlterar;