using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public enum CellAttribute
    {
        // 属性なし
        NONE=1,

        // 爆弾
        BOMB=2,

        // 周囲に爆弾あり
        NUMBER=3
    }

    class Cell
    {
        /// <summary>
        /// セルの属性を保持
        /// </summary>
        public CellAttribute cellAttribute = CellAttribute.NONE;
        public bool IsOpened = false;
        public int bombCount = 0;
        
        public bool IsNone()
        {
            return cellAttribute == CellAttribute.NONE ? true : false;
        }

        public bool IsBomb()
        {
            return cellAttribute == CellAttribute.BOMB ? true : false;
        }

        public bool IsNumber()
        {
            return cellAttribute == CellAttribute.NUMBER ? true : false;
        }

        public void Open()
        {
            IsOpened = true;
        }

        public void ToBomb()
        {
            cellAttribute = CellAttribute.BOMB;
        }

        public void ToNumber()
        {
            cellAttribute = CellAttribute.NUMBER;
        }

        public void SetBombNumber(int bombCount)
        {
            this.bombCount = bombCount;
            if(bombCount > 0)
            {
                ToNumber();
            }
        }
    }
}
