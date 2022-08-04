import sys
from Node import Node
from AStarAlgorithm import AStarAlgorithm

class App(object):

    def __init__(self):
        print("Creando nodos: ", end = '')
        
        
        self.a = Node("A", 15)
        self.b = Node("B", 10)
        self.c = Node("C", 12)
        self.d = Node("D", 9)
        self.e = Node("E", 9)
        self.f = Node("F", 10)
        self.g = Node("G", 9)
        self.h = Node("H", 7)
        self.i = Node("I", 7)
        self.j = Node("J", 7)
        self.k = Node("K", 7)
        self.l = Node("L", 9)
        self.m = Node("M", 7)
        self.ñ = Node("Ñ", 7)
        self.n = Node("N", 7)
        self.o = Node("O", 8)
        self.p = Node("P", 8)
        self.q = Node("Q", 8)
        self.r = Node("R", 8)
        self.s = Node("S", 8)
        self.t = Node("T", 8)
        self.u = Node("U", 8)
        self.v = Node("V", 8)
        self.w = Node("W", 8)
        self.x = Node("X", 8)
        self.y = Node("Y", 8)
        self.z = Node("Z", 8)
        self.a1 = Node("A1", 8)
        self.a2 = Node("A2", 8)

        self.a.addChild(self.b, 1)
        self.a.addChild(self.c, 1)
        print("A ", end ='')

        self.b.addChild(self.d, 2)
        self.b.addChild(self.e, 2)
        print("B ", end ='')
        self.c.addChild(self.f, 2)
        self.c.addChild(self.g, 2)
        print("C ", end ='')


        self.d.addChild(self.h, 3)
        self.d.addChild(self.i, 3)
        print("D ", end ='')
        self.e.addChild(self.j, 3)
        self.e.addChild(self.k, 3)
        print("E ", end ='')
        self.f.addChild(self.l, 3)
        self.f.addChild(self.m, 3)
        print("F ", end ='')
        self.g.addChild(self.ñ, 3)
        self.g.addChild(self.n, 3)
        print("G ", end ='')

        print("O ", end ='')
        print("P ", end ='')
        print("Q ", end ='')
        print("R ", end ='')
        print("S ", end ='')
        print("T ", end ='')
        print("U ", end ='')
        print("V ", end ='')
        print("W ", end ='')
        print("X ", end ='')
        print("Y ", end ='')
        print("Z ", end ='')
        print("A1 ", end ='')
        print("A2 ", end ='')


    def searchAStarAlgorithm(self):
        print("\nBuscando ruta optima con Algoritmo A*")
        astar = AStarAlgorithm(self.i, self.f)
        print("Nodo Inicial: %s -----> Nodo Final %s" % (self.i.name, self.f.name))
        astar.run()


if __name__ == "__main__":
    try:
        app = App()
        app.searchAStarAlgorithm()
    except (ValueError, FileNotFoundError, AttributeError) as ex:
        print(ex)