import { useEffect, useState } from "react";
import { Tarefa } from "../models/Tarefa";
import axios from "axios";

function TarefaNaoConcluida() {
    const [tarefa, setTarefa] = useState<Tarefa[]>([]);

    useEffect(() => {
        carregarTarefas();
    }, []);

    function carregarTarefas() {
        axios.get<Tarefa[]>('http://localhost:5000/api/tarefas/naoconcluidas').then((resposta) => {
            setTarefa(resposta.data);
        }).catch((error) => {
            console.log("Erro: " + error);
        });
    }

    return( 
        <div>
            <h1>Tarefas Não Concluidas</h1>
            <table>
                <thead>
                    <tr>
                        <th>Tarefa ID</th>
                        <th>Titulo</th>
                        <th>Descrição</th>
                        <th>Status</th>
                        <th>Categoria ID</th>
                        <th>Criado em</th>
                    </tr>
                </thead>
                <tbody>
                    {tarefa.map((tarefa) => (
                        <tr key={tarefa.tarefaId}>
                            <td>{tarefa.tarefaId}</td>
                            <td>{tarefa.titulo}</td>
                            <td>{tarefa.descricao}</td>
                            <td>{tarefa.status}</td>
                            <td>{tarefa.categoriaId}</td>
                            <td>{tarefa.criadoEm}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}

export default TarefaNaoConcluida;