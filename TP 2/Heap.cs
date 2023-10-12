/*
 * Created by SharpDevelop.
 * User: Braian
 * Date: 27/8/2023
 * Time: 16:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TP_2
{
    public class Heap
    {
        public Heap()
        {

        }

        //Metodos


        public int[] BuildHeapMin(int[] data)
        {
            //buscamos la mitad de la heap

            int MitadHeap = data.Length / 2;


            //creamos un for para los valores de la mitad para atras
            for (int i = MitadHeap - 1; i >= 0; i--)
            {

                //creamos variables de indice para el hijo izq y el hijo der

                int hijoizq = i * 2 + 1;
                int hijoder = i * 2 + 2;


                if (data.Length > hijoizq)
                {//evaluamos si alguno de los hijos es mayor al padre


                    if (data[i] >= data[hijoizq])
                    {

                        int aux = data[i];
                        data[i] = data[hijoizq];

                        data[hijoizq] = aux;
                        BuildHeapMin(data);

                    }
                }


                if (data.Length > hijoder)
                {

                    if (data[i] > data[hijoder])
                    {


                        int aux = data[i];
                        data[i] = data[hijoder];

                        data[hijoder] = aux;
                        BuildHeapMin(data);
                    }
                }
            }
            return data;

        }




    }
}
		
		
		
	

