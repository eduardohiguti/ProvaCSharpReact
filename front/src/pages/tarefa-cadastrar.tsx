import { useEffect, useState } from "react";
import axios from "axios";

function TarefaCadastrar() {
    const [titulo, setTitulo] = useState("");
    const [descricao, setDescricao] = useState("");
    const [categoriaId, setCategoriaId] = useState("");

    function cadastrarTarefa(event : any) {
        event.preventDefault();
        const tarefa = {
            titulo: titulo,
            descricao: descricao,
            categoriaId: categoriaId,
            status: "Não iniciada",
        };

        axios.post('http://localhost:5000/api/tarefas/cadastrar', tarefa, {
            headers: {
                'Content-Type': 'application/json',
            },
        })
        .then((response) => {
           console.log(response.data);
        })
        .catch((error) => {
            console.error('Erro ao cadastrar tarefa:', error);
        });
}

return (
    <div>
        <h1>Cadastrar Tarefa</h1>
        <form onSubmit={cadastrarTarefa}>
            <div>
                <label>Titulo</label>
                <input 
                    type="text" 
                    placeholder="Titulo da tarefa" 
                    onChange={(e) => setTitulo(e.target.value)} 
                    required>
                </input>
            </div>
            <div>
                <label>Descrição</label>
                <input
                    type="text"
                    placeholder="Descrição da tarefa"
                    onChange={(e) => setDescricao(e.target.value)}
                    required>
                </input>
            </div>
            <div>
                <label>Categoria</label>
                <input
                    type="text"
                    placeholder="Categoria da tarefa"
                    onChange={(e) => setCategoriaId(e.target.value)}
                    required>
                </input>
            </div>
            <div>
                <button type="submit">Cadastrar</button>
            </div>
        </form>
    </div>
);
}

export default TarefaCadastrar;