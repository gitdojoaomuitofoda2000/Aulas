using JetBrains.Annotations;
using UnityEngine;


public struct InventoryExercicio
{
    public string Name;
    public float price;
    public float weight;
};


public class ExercicioStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InventoryExercicio EspadaAço = new InventoryExercicio();
        EspadaAço.Name = "Espada Longa de Aço";
        EspadaAço.price = 100.0f;
        EspadaAço.weight = 1.5f;

        InventoryExercicio EscudoCarvalho = new InventoryExercicio();
        EscudoCarvalho.Name = "Escudo de Caralho";
        EscudoCarvalho.price = 80.0f;
        EscudoCarvalho.weight = 2.0f;

        InventoryExercicio PoçaoCura = new InventoryExercicio();
        PoçaoCura.Name = "Poção de Cura";
        PoçaoCura.price = 20.0f;
        PoçaoCura.weight = 0.3f;

        InventoryExercicio ElixirMana = new InventoryExercicio();
        ElixirMana.Name = "Elixir de Mana";
        ElixirMana.price = 15.0f;
        ElixirMana.weight = 0.3f;

        InventoryExercicio RaçõesViagem = new InventoryExercicio();
        RaçõesViagem.Name = "Rações de Viagem";
        RaçõesViagem.price = 10.0f;
        RaçõesViagem.weight = 0.5f;

        InventoryExercicio Corda = new InventoryExercicio();
        Corda.Name = "Corda de Cânhamo (10m)";
        Corda.price = 50.0f;
        Corda.weight = 785.0f;
        
        InventoryExercicio AdagaEnvenenada = new InventoryExercicio();
        AdagaEnvenenada.Name = "Adaga Envenenada";
        AdagaEnvenenada.price = 115;
        AdagaEnvenenada.weight = 0.6f;

        InventoryExercicio CajadoFogo = new InventoryExercicio();
        CajadoFogo.Name = "Cajado de Fogo";
        CajadoFogo.price = 20.0f;
        CajadoFogo.weight = 0.2f;

        InventoryExercicio Gazuas = new InventoryExercicio();
        Gazuas.Name = "Gazuas de Ladrão";
        Gazuas.price = 10.0f;
        Gazuas.weight = 0.1f;

        InventoryExercicio PergaminhoFogo = new InventoryExercicio();
        PergaminhoFogo.Name = "Pergaminho de Bola de Fogo";
        PergaminhoFogo.price = 200.0f;
        PergaminhoFogo.weight = 0.1f;


        InventoryExercicio[] inventoryNovo = new InventoryExercicio[10];

        inventoryNovo[0] = EspadaAço;
        inventoryNovo[1] = EscudoCarvalho;
        inventoryNovo[2] = PoçaoCura;
        inventoryNovo[3] = ElixirMana;
        inventoryNovo[4] = RaçõesViagem;
        inventoryNovo[5] = Corda;
        inventoryNovo[6] = AdagaEnvenenada;
        inventoryNovo[7] = CajadoFogo;
        inventoryNovo[8] = Gazuas;
        inventoryNovo[9] = PergaminhoFogo;

        int itemSorteado = Random.Range(0, inventoryNovo.Length);
        int itemArmadilha = Random.Range(0, 2);

        for (int i = 0; i < inventoryNovo.Length; i++)
        {

            if (itemArmadilha == 0)
            {
              inventoryNovo[itemSorteado].Name = "Espada de Plástico";
               inventoryNovo[itemSorteado].price = 1.0f;
                inventoryNovo[itemSorteado].weight = 0.5f; 
            }

            else
            {
                inventoryNovo[itemSorteado].Name = "Poçao de Coco";
                 inventoryNovo[itemSorteado].price = 0.0f;
                  inventoryNovo[itemSorteado].weight = 0.1f;
            }

            Debug.Log("Item: " + inventoryNovo[i].Name + "Preço: " + inventoryNovo[i].price + "Peso: " + inventoryNovo[i].weight);
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
