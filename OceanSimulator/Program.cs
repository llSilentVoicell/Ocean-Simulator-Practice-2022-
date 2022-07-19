using OceanLib;
using System;
using System.Threading;
using System.Threading.Tasks;
using OceanLib.Interfaces;

namespace OceanSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 160;
            Console.WindowHeight = 40;

            Ocean myFirstOcean = new Ocean();
            Ocean mySecondOcean = new Ocean();

            OceanViewer oceanView = new OceanViewer();

            oceanView.SetNumOfOceans();

            Thread firstThread;
            Thread secondThread;

            if (oceanView.numOfOceans == 1)
            {
                Task taskForOneOcean = Task.Run(() =>
                {
                    IDisplayElements elements = new ElementsForDisplay();
                    IOceanView viewer = new OceanViewer();
                    IEnterDisplayData data = new OceanViewer();

                    firstThread = new Thread(() =>
                    {
                        Console.CursorVisible = false;

                        for (int iteration = 0; iteration < viewer.UserNumIteration; iteration++)
                        {
                            if (myFirstOcean.NumPrey > 0 && myFirstOcean.NumPredators > 0)
                            {
                                myFirstOcean.Run(iteration);

                                elements.CountParticipants(myFirstOcean);
                                data.Display(iteration, myFirstOcean, (int)(oceanView.numOfOceans), viewer.UserNumIteration);

                                Thread.Sleep(Constants.FrameChangeDelay);
                            }
                            else
                            {
                                break;
                            }
                        }

                        data.EndSimulation((int)oceanView.numOfOceans);
                    })
                    {
                        IsBackground = false
                    };

                    data.EnterNumOfObjects((int)oceanView.numOfOceans,  viewer);
                    data.EnterNumOfIterations(viewer);

                    myFirstOcean.Initialize(viewer);

                    Console.Clear();

                    firstThread.Start();

                    firstThread.Join();
                });

                taskForOneOcean.Wait();

                oceanView.CloseApp((int)oceanView.numOfOceans);
            }

            if (oceanView.numOfOceans == 2)
            {
                Task taskForTwoOceans = Task.Run(() =>
                {
                    IDisplayElements elements = new ElementsForDisplay();
                    IOceanView firstviewer = new OceanViewer();
                    IOceanView secondviewer = new OceanViewer();
                    IEnterDisplayData firstdata = new OceanViewer();
                    IEnterDisplayData seconddata = new OceanViewer();

                    firstThread = new Thread(() =>
                    {
                        Console.CursorVisible = false;

                        for (int iteration = 0; iteration < firstviewer.UserNumIteration; iteration++)
                        {
                            if (myFirstOcean.NumPrey > 0 && myFirstOcean.NumPredators > 0)
                            {
                                myFirstOcean.Run(iteration);

                                elements.CountParticipants(myFirstOcean);
                                firstdata.Display(iteration, myFirstOcean, (int)(oceanView.numOfOceans - 1), firstviewer.UserNumIteration);

                                Thread.Sleep(Constants.FrameChangeDelay);
                            }
                            else
                            {
                                break;
                            }
                        }

                        firstdata.EndSimulation((int)(oceanView.numOfOceans-1));
                    })
                    {
                        IsBackground = false
                    };

                    secondThread = new Thread(() =>
                    {
                        Thread.Sleep(Constants.FrameChangeDelay / 2);

                        for (int iteration = 0; iteration < secondviewer.UserNumIteration; iteration++)
                        {
                            if (mySecondOcean.NumPrey > 0 && mySecondOcean.NumPredators > 0)
                            {
                                mySecondOcean.Run(iteration);

                                elements.CountParticipants(mySecondOcean);
                                seconddata.Display(iteration, mySecondOcean, (int)oceanView.numOfOceans, secondviewer.UserNumIteration);

                                Thread.Sleep(Constants.FrameChangeDelay);
                            }
                            else
                            {
                                break;
                            }
                        }

                        seconddata.EndSimulation((int)oceanView.numOfOceans);
                    })
                    {
                        IsBackground = false
                    };

                    firstdata.EnterNumOfObjects((int)(oceanView.numOfOceans - 1), firstviewer);
                    firstdata.EnterNumOfIterations(firstviewer);

                    myFirstOcean.Initialize(firstviewer);

                    seconddata.EnterNumOfObjects((int)(oceanView.numOfOceans), secondviewer);
                    seconddata.EnterNumOfIterations(secondviewer);

                    mySecondOcean.Initialize(secondviewer);

                    Console.Clear();

                    firstThread.Start();
                    secondThread.Start();

                    firstThread.Join();
                    secondThread.Join();
                });

                taskForTwoOceans.Wait();

                oceanView.CloseApp((int)oceanView.numOfOceans);
            }
        }
    }
}
