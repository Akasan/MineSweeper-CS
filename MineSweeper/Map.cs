using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace MineSweeper
{
    class Map
    {
        private Cell[,] map;
        private List<(int, int)> bombPosition;
        private int firstClickedI, firstClickedJ;
        private int pictureBoWidth;
        private int pictureBoHeight;
        private int rowCellNum, colCellNum;
        private int size;
        private Random indexRandomizer = new System.Random();
        public int BombNum;
        

        public Map(int pictureBoWidth, int pictureBoHeight, int size, int bombNum)
        {
            this.pictureBoWidth = pictureBoWidth;
            this.pictureBoHeight = pictureBoHeight;
            rowCellNum = pictureBoHeight / size;
            colCellNum = pictureBoWidth / size;
            this.size = size;
            this.BombNum = bombNum;
            bombPosition = new List<(int, int)>();
            map = new Cell[pictureBoHeight / size, pictureBoWidth / size];

            for(int i=0; i< pictureBoHeight / size; i++)
            {
                for(int j=0; j< pictureBoWidth / size; j++)
                {
                    map[i, j] = new Cell();
                }
            }
        }

        public void InitializeMap(int firstClickedY, int firstClickedX)
        {
            (firstClickedJ, firstClickedI) = PixelToCellIndex(firstClickedY, firstClickedX);
            GenerateMap();
        }

        private void GenerateMap()
        {
            GenerateBombPosition();
            GenerateNumber();
        }

        public IEnumerable<(int, int, Cell)> GetPositionCellPair()
        {
            int i, j;

            for (j = 0; j < rowCellNum; j++)
            {
                for (i = 0; i < colCellNum; i++)
                {
                    yield return (j * size, i * size, map[j, i]);
                }
            }
        }

        private void GenerateBombPosition()
        {
            int bombCount = 0;
            int candidateI, candidateJ;

            while (bombCount < BombNum)
            {
                candidateJ = indexRandomizer.Next(0, rowCellNum);
                candidateI = indexRandomizer.Next(0, colCellNum);
                if (!map[candidateJ, candidateI].IsBomb() && candidateI != firstClickedI && candidateJ != firstClickedJ)
                {
                    bombPosition.Add((candidateJ, candidateI));
                    map[candidateJ, candidateI].ToBomb();
                    bombCount += 1;
                }
            }
        }

        private void GenerateNumber()
        {
            int i, j;
            int nearBombCount;

            for(j=0; j<rowCellNum; j++)
            {
                for(i=0; i<colCellNum; i++)
                {
                    if(!map[j, i].IsBomb())
                    {
                        nearBombCount = CountNeghborBomb(j, i);
                        map[j, i].SetBombNumber(nearBombCount);
                    }
                    
                }
            }
        }

        /// <summary>
        /// 指定したセルの8近傍にある爆弾の個数を取得
        /// </summary>
        /// <param name="j">高さ方向のインデックス</param>
        /// <param name="i">横方向のインデックス</param>
        /// <returns></returns>
        private int CountNeghborBomb(int j, int i)
        {
            int x, y;
            int bombCount = 0;

            for(x=-1; x<=1; x++)
            {
                for(y=-1; y<=1; y++)
                {
                    if(bombPosition.Contains((j+y, i + x)))
                    {
                        bombCount += 1;
                    }
                }
            }
            return bombCount;
        }


        public Cell this[int y, int x]
        {
            get
            {
                (int, int) cellIndex = PixelToCellIndex(y, x);
                return map[cellIndex.Item1, cellIndex.Item2];
            }
        }

        private (int, int) PixelToCellIndex(int i, int j)
        {
            int pixelI = i / size;
            int pixelJ = j / size;
            return (pixelI, pixelJ);
        }
    }
}
