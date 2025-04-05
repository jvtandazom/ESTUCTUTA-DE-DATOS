
#include <iostream>
#include <vector>
#include <queue>
#include <limits>

using namespace std;

const int INF = numeric_limits<int>::max();

struct Edge {
    int destino;
    int costo;
};

// Algoritmo de Dijkstra
vector<int> dijkstra(int origen, const vector<vector<Edge>>& grafo) {
    vector<int> distancias(grafo.size(), INF);
    distancias[origen] = 0;

    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;
    pq.push({0, origen});

    while (!pq.empty()) {
        int distanciaActual = pq.top().first;
        int nodoActual = pq.top().second;
        pq.pop();

        if (distanciaActual > distancias[nodoActual]) continue;

        for (const auto& arista : grafo[nodoActual]) {
            int vecino = arista.destino;
            int costo = arista.costo;

            if (distancias[nodoActual] + costo < distancias[vecino]) {
                distancias[vecino] = distancias[nodoActual] + costo;
                pq.push({distancias[vecino], vecino});
            }
        }
    }

    return distancias;
}

int main() {
    // Mapa de ciudades (índices)
    vector<string> ciudades = {
        "Loja",        // 0
        "Quito",       // 1
        "Guayaquil",   // 2
        "Cuenca",      // 3
        "Manta",       // 4
        "Ambato"       // 5
    };

    // Crear el grafo con 6 nodos
    vector<vector<Edge>> grafo(6);

    // Agregar vuelos (conexiones) con costos
    grafo[0].push_back({2, 50});  // Loja → Guayaquil
    grafo[0].push_back({3, 70});  // Loja → Cuenca
    grafo[2].push_back({1, 60});  // Guayaquil → Quito
    grafo[3].push_back({1, 80});  // Cuenca → Quito
    grafo[2].push_back({4, 40});  // Guayaquil → Manta
    grafo[4].push_back({1, 55});  // Manta → Quito
    grafo[3].push_back({5, 35});  // Cuenca → Ambato
    grafo[5].push_back({1, 45});  // Ambato → Quito

    // Ejecutar Dijkstra desde Loja (nodo 0)
    vector<int> distancias = dijkstra(0, grafo);

    // Mostrar resultados
    cout << "🚀 Costo mínimo desde Loja a las demás ciudades:\n\n";
    for (int i = 0; i < ciudades.size(); ++i) {
        cout << "- " << ciudades[i] << ": ";
        if (distancias[i] == INF) {
            cout << "No hay ruta disponible.\n";
        } else {
            cout << "$" << distancias[i] << "\n";
        }
    }

    return 0;
}
