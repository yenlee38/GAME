using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace game
{
    public partial class GAME : Form
    {

        #region F

        public int speedPlayer = 30;
        public int speedFish = 30;
        public int score = 0;
        public int speedShip = 30;
        public int speedBomb = 15;
        public int bonus_Heart = 0;

        public bool isStartShip = false;
        public bool isStartTimerMain = true;
        public int haveBomb;

        int countFish = 4; // đếm số lượng cá có trong control 
        int fishCanEat = 1; // đặt xem loại cá nào mà người chơi có thể ăn
        int heart = 3;
        Point pAppear = new Point(400, 400); // vị trí xuất hiện ban đầu của cá
        Point pLeft;
        Point pRight;
        Random rnd = new Random();

        /// <summary>
        /// Mảng chuỗi số hiệu của từng loại cá trong control
        /// </summary>
        string[] pointFish = new string[] { "01", "07", "15", "20", "40" }; 

        /// <summary>
        /// Mảng trạng thái trái hay phải của cá
        /// </summary>
        string[] showFish = new string[] { "Left", "Right" };

        WindowsMediaPlayer loseSound;
        WindowsMediaPlayer eatFishSound;
        WindowsMediaPlayer gameOverSound;
        WindowsMediaPlayer playSound;
        WindowsMediaPlayer winGameSound;

        #endregion


        public GAME()
        {
            haveBomb = 0;
            InitializeComponent();
            player.Location = pAppear;
            createPlayer("Right");
            setBackColor();
            createFish(pic01, "01", "Left");
            pLeft = pic01.Location;
            createFish(pic02, "01", "Left");
            createFish(pic03, "01", "Right");
            createFish(pic04, "01", "Right");
            pRight = pic04.Location;
            lbGameOver.Hide();
            player.BringToFront();


        }

        private void Game_Load(object sender, EventArgs e)
        {
            tmMain.Start();

            //tạo âm thanh khi ăn cá
            eatFishSound = new WindowsMediaPlayer();
            eatFishSound.URL = "songs\\eatFish.mp3";

            //Tạo âm thanh khi bị cá xung quanh ăn
            loseSound = new WindowsMediaPlayer();
            loseSound.URL = "songs\\lose.mp3";

            //Tạo âm thanh GAMEOVER
            gameOverSound = new WindowsMediaPlayer();
            gameOverSound.URL = "songs\\gameOver.mp3";

            //Taọ âm thanh đang chơi
            playSound = new WindowsMediaPlayer();
            playSound.URL = "songs\\play.mp3";

            //Tạo âm thanh khi thắng
            winGameSound = new WindowsMediaPlayer();
            winGameSound.URL = "songs\\winLevel.mp3";

            gameOverSound.controls.stop();
            loseSound.controls.stop();
            eatFishSound.controls.stop();

            
        }

        private void setBackColor()
        {
            ship.BackColor = Color.Transparent;
            player.BackColor = Color.Transparent;
            this.lbHeart.BackColor = Color.Transparent;
            this.lbLevel.BackColor = Color.Transparent;
            this.lbScore.BackColor = Color.Transparent;
            this.ptbFish01.BackColor = Color.Transparent;
            this.ptbFish07.BackColor = Color.Transparent;
            this.ptbFish15.BackColor = Color.Transparent;
            this.ptbFish20.BackColor = Color.Transparent;
            this.ptbFish40.BackColor = Color.Transparent;
            lbLevel.BackColor = Color.Transparent;
            lbHeart.BackColor = Color.Transparent;
            lbScore.BackColor = Color.Transparent;
            ship.Hide();
            ptbFish07.Hide();
            ptbFish15.Hide();
            ptbFish20.Hide();
            ptbFish40.Hide();

        }



        #region KEYDOWN_UP
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space) // dừng màn hình
            {
                isStartTimerMain = !isStartTimerMain;
            }

            if (isStartTimerMain)
            {
                tmMain.Start();
                playSound.controls.play();
                timer_soundPlay.Start();
                
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        {
                            if (player.Left >= 0)
                            {
                                createPlayer("Left");
                                player.Left -= speedPlayer;
                            }
                            break;
                        }
                    case Keys.Right:
                        {
                            if (player.Left <= this.Width - 80)
                            {
                                createPlayer("Right");
                                player.Left += speedPlayer;
                            }
                            break;
                        }
                    case Keys.Up:
                        {
                            if (player.Top > 130)
                            {
                                createPlayer("up");
                                player.Top -= speedPlayer;
                            }
                            break;
                        }
                    case Keys.Down:
                        {
                            if (player.Top <= this.Height - 80)
                            {
                                createPlayer("Down");
                                player.Top += speedPlayer;
                            }
                            break;
                        }

                }
            }
            else
            {
                timer_soundPlay.Stop();
                playSound.controls.stop();
                
                tmMain.Stop();
            }

            if (player.Top <= 130 && heart > 0)
                playerDie();
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        #endregion

        #region TIMER_TICK
       
        private void timer_Heart_Tick(object sender, EventArgs e)
        {
            createHeart();
            bonus_Heart++;
        }

        private void timer_soundPlay_Tick(object sender, EventArgs e)
        {
            playSound.controls.play();
        }

        private void tmMain_Tick(object sender, EventArgs e)
        {
            if (score >= 300)
                winGame();
            else

            {
                checkLevelForPlayer();
                if (isStartShip)
                {
                    ship.Left += speedShip;
                    if (ship.Left >= this.Width)
                        ship.Left = 0;

                }
                int n = 1; //số boom max 
                if (score > 5)
                    n = 3;
                if (score > 15)
                    n = 5;
                if (score > 100)
                {
                    n = 6;
                    speedBomb = 30;
                }

                if (haveBomb < n)
                {

                    createBomb();
                    haveBomb++;
                    haveboom.Text = haveBomb.ToString();
                }

                foreach (Control fish in Controls)
                {
                    if (fish.Tag != null)
                        if (fish is PictureBox && fish.Tag != "player" && fish.Tag != "bomb" && fish.Tag != "heart")
                            isFishForEat(fish as PictureBox);

                }


                foreach (Control bomb in Controls)
                {
                    if (bomb is PictureBox && bomb.Tag == "bomb")
                    {
                        isBomb(bomb as PictureBox);
                    }
                }


                if (heart < 2 && bonus_Heart == 0 && score > 30)
                {
                    timer_Heart.Enabled = true;
                }
                else
                    timer_Heart.Enabled = false;


                foreach (Control Heart in Controls)
                {
                    if (Heart is PictureBox && Heart.Tag == "heart")
                    {

                        if (Heart.Bounds.IntersectsWith(player.Bounds))
                        {

                            heart++;
                            lbHeart.Text = "Heart: " + heart;
                            this.Controls.Remove(Heart);
                            Heart.Dispose();
                            bonus_Heart = 0;
                        }
                        else
                        {
                            Heart.Top += 15;
                            if (Heart.Bounds.IntersectsWith(panel1.Bounds)) //panel đặt ở cuối màn hình
                            {
                                bonus_Heart = 0;
                                Heart.Dispose();

                            }

                        }

                    }


                }

            }

            this.Update();
        }

        #endregion

        #region BOMB

        private void isBomb(PictureBox bomb)
        {
            if (bomb.Bounds.IntersectsWith(player.Bounds))
            {
                loseSound.controls.play();
                playerDie();
                bomb.Location = new System.Drawing.Point(rnd.Next(0, 900), 140);
            }
            else
            {
                bomb.Top += speedBomb;
                if (bomb.Bounds.IntersectsWith(panel1.Bounds)) //panel đặt ở cuối màn hình
                {
                    bomb.Location = new System.Drawing.Point(rnd.Next(0, 900), 140);
                }
            }
        }

        #endregion

        #region FISH_FOR_EAT
        private void isFishForEat(PictureBox fish)
        {
            if (checkBoundPlayer(fish) == 0)
            {
                string fishTag = fish.Tag.ToString();

                if (score >= 40)
                    speedFish = 40;

                if (fishTag.Contains("Left"))
                    fish.Left -= speedFish;
                else
                    fish.Left += speedFish;

                if (fish.Left >= this.Width)
                {
                    createFish(fish, takePointFish(fishTag), "Left");
                    fish.Location = setPointAppear("Left");
                }
                else
                    if (fish.Left <= -50)
                {
                    createFish(fish, takePointFish(fishTag), "Right");
                    fish.Location = setPointAppear("Right");
                }
            }

        }

        private int checkBoundPlayer(PictureBox fish)
        {
            if (fish.Bounds.IntersectsWith(player.Bounds))
            {
               
                if (canEat(fish))
                {
                    eatFishSound.controls.play();
                    if (takePointFish(fish.Tag.ToString()) == "01")
                    {
                        string show = showFish[rnd.Next(0, 2)];

                        fish.Location = setPointAppear(show);
                    }
                    else
                    {
                        this.Controls.Remove(fish);
                        fish.Dispose();
                        countFish--;
                    }
                    
                    setScore(fish);

                    // Tạo thêm các loại cá khác
                    if (countFish <= 10)
                    {
                        createNewFish();
                        countFish++;
                    }
                  
                }

                else
                {
                    loseSound.controls.play();
                    this.Controls.Remove(fish);
                    fish.Dispose();
                    countFish--;

                    playerDie();
                }

                return 1;
            }
            return 0;
        }

        private bool canEat(PictureBox fish)
        {
            if (Int16.Parse(takePointFish((fish.Tag).ToString())) <= fishCanEat)
                return true;
            return false;
        }

        #endregion

        #region SCORE

        private void totalScore(PictureBox fish)
        {
            score += Int16.Parse(fish.Tag.ToString().Substring(1, 2));
        }

        private void setScore(PictureBox fish)
        {
            totalScore(fish);
            lbScore.Text = "Score: " + score;

            if (score >= 7)
            {
                this.ptbFish07.Show();
                fishCanEat = 7;
            }

            if (score >= 20)
            {
                this.ptbFish15.Show();
                fishCanEat = 15;
            }

            if (score >= 30)
            {
                this.ptbFish20.Show();
                fishCanEat = 20;
            }

            if (score >= 100)
            {
                this.ptbFish40.Show();
                fishCanEat = 40;
            }

            if (score >= 0)
            {
                ship.Show();
                isStartShip = true;

            }
        }

        #endregion

        #region GAME_OVER_PLAYER_DIE

        /// <summary>
        /// khi người chơi đặt được số điểm cao ví dụ quy định là 200 điểm thắng
        /// </summary>
        private void winGame()
        {
            lbGameOver.Text = "YOU WIN !";
            winGameSound.controls.play();
            gameOver();
            
        }
        private void gameOver()
        {          
            lbGameOver.Show();
            lbGameOver.BringToFront();
            timer_Heart.Stop();
            isStartTimerMain = false;
            timer_soundPlay.Stop();
            playSound.controls.stop();
            tmMain.Stop();
        }
        private void playerDie()
        {

            heart--;
            lbHeart.Text = "Heart: " + heart;

            if (heart == 0)
            {
                gameOverSound.controls.play();
                gameOver();
            }
            else if (heart >  0)
            {
                player.Location = pAppear;
            }
        }
        #endregion

        #region TAKE_LEVEL_SHOW_POINT
        /// <summary>
        /// Kiểm tra số điểm (score) để tăng level cho người chơi
        /// </summary>
        private void checkLevelForPlayer()
        {
            if (score >= 200)
            {
                lbLevel.Text = "Level: 03";
                speedFish = 50;
            }
            else if (score >= 100)
            {
                lbLevel.Text = "Level: 02";
                speedFish = 40;
            }
        }
        private string takeLevelPlayer()
        {
            return lbLevel.Text.Substring(lbLevel.Text.Length - 2);
        }

        private string takeShowFish(string fishTag)
        {
            return fishTag.Substring(3, fishTag.Length - 3);
        }

        private string takePointFish(string fishTag)
        {
            return fishTag.Substring(1, 2);
        }
        
        /// <summary>
        /// Xét vị trí xuất hiện ngẫu nhiên của cá thông qua thuộc tính Show: trái hay phải
        /// </summary>
        /// <param name="show"></param>
        /// <returns></returns>
        private Point setPointAppear(string show)
        {
            Point p = new Point();
            if (show == "Left")
            {
                p.X = this.Width;
                p.Y = rnd.Next(200, this.Height - 80);
            }

            else
            {
                p.X = -50;
                p.Y = rnd.Next(200, this.Height - 80);
            }
            return p;
        }

        #endregion

        #region CREATE_CONTROL

        private void createHeart()
        {
            Random rng = new Random();
            PictureBox Heart = new PictureBox();
            Heart.Image = Properties.Resources.heart;
            Heart.Location = new System.Drawing.Point(rng.Next(0, 900), 140);
            Heart.Size = new Size(30, 30);
            Heart.BackColor = Color.Transparent;
            Heart.SizeMode = PictureBoxSizeMode.StretchImage;
            Heart.Tag = "heart";

            Controls.Add(Heart);
            Heart.BringToFront();

        }

        private void createBomb()
        {
          
            Random rng = new Random();
            PictureBox bomb = new PictureBox();
            bomb.Image = Image.FromFile("Resources\\bomb.png");
            //thay đổi dòng này 
            bomb.Size = new Size(30, 30);
            bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            bomb.Location = new System.Drawing.Point(rng.Next(0, 900), 140);
            bomb.BackColor = Color.Transparent;
            bomb.Tag = "bomb";
            bomb.Name = "pb";
            Controls.Add(bomb);
            bomb.BringToFront();
        }

        /// <summary>
        /// Random tạo cá mới, nếu số điểm từ 30 trở lên sẽ tạo cá 40 điểm
        /// </summary>
        private void createNewFish()
        {
            PictureBox fishNew = new PictureBox();

            int indexFish;

            if (score >= 30)
                indexFish = pointFish.Length;
            else
                indexFish = pointFish.Length - 1;
            string point = pointFish[rnd.Next(1, indexFish)];
            string show = showFish[rnd.Next(0, 2)];
            createFish(fishNew, point, show);

            fishNew.Location = setPointAppear(show);
        }

        /// <summary>
        /// Tạo cá 1 điểm cho người chơi
        /// </summary>
        private void createFishOnePoint()
        {
            string show = showFish[rnd.Next(0, 2)];
            PictureBox fish01 = new PictureBox();
            createFish(fish01, "01", show);
            //fish01.Tag =
            fish01.Location = setPointAppear(show);
        }

        private void createPlayer(string show)
        {
            string tempLevel = takeLevelPlayer();
            player.Image = Image.FromFile("Resources\\" + "lv" + tempLevel + show + ".png");
            if(tempLevel == "02")
                player.Size = new Size(100, 70);
            else if(tempLevel == "03")
                player.Size = new Size(130, 80);
        }
        /// <summary>
        /// Tạo các loại cá xung quanh theo:
        /// Point: 01, 07, 15, 20, 40, show: Left, Right
        /// </summary>
        /// <param name="fish"></param>
        /// <param name="point"></param>
        /// <param name="show"></param>
        private void createFish(PictureBox fish, string point, string show)
        {
           
            fish.Image = Image.FromFile("Resources\\" + "fish" + point + "point" + show + ".png");
            fish.Tag = "f" + point + show; // ví dụ: f01Left
            setSizeForFish(fish, point);
            fish.BackColor = Color.Transparent;
            fish.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(fish);
        }

        private void setSizeForFish(PictureBox fish, string point)
        {
            switch(point)
            {
                case "40":
                    {
                        fish.Size = new Size(200, 95);
                        break;
                    }
                case "20":
                    {
                        fish.Size = new Size(85, 45);
                        break;
                    }
                case "15":
                    {
                        fish.Size = new Size(70, 40);
                        break;
                    }
                case "07":
                    {
                        fish.Size = new Size(35, 95);
                        break;
                    }
                case "01":
                    {
                        fish.Size = new Size(60, 30);
                        break;
                    }
            }
        }


        #endregion    
    }
}
