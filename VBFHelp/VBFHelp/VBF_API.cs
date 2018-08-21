using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace VBFHelp
{
    public struct CAN_Block
    {
        public byte type;							// block type	
        public byte[] flash_addr;// block flash adddress
        public byte[] size;		// block size
        public int start_offset;					// block offset(bytes) in file
        public int end_offset;
        public byte[] checksum;	// not used
        public byte is_last;						// the last block flag

    };

    public struct CAN_File
    {
        public byte[] name;	// file name
        public byte type;							// file type	
        public int size;							// file size
        public byte is_last_file;					// 
        public byte block_count;					// block count, 1~10
        public CAN_Block[] block_array;	        // block data
        public byte[] erase_size;				// erase size
        public byte[] crc32;				// crc32

    };



    public class VBF_API
    {
         public long[] ssh_crc32_tbl = new long[256] {  
	        0x00000000L, 0x77073096L, 0xee0e612cL, 0x990951baL,
	        0x076dc419L, 0x706af48fL, 0xe963a535L, 0x9e6495a3L,
	        0x0edb8832L, 0x79dcb8a4L, 0xe0d5e91eL, 0x97d2d988L,
	        0x09b64c2bL, 0x7eb17cbdL, 0xe7b82d07L, 0x90bf1d91L,
	        0x1db71064L, 0x6ab020f2L, 0xf3b97148L, 0x84be41deL,
	        0x1adad47dL, 0x6ddde4ebL, 0xf4d4b551L, 0x83d385c7L,
	        0x136c9856L, 0x646ba8c0L, 0xfd62f97aL, 0x8a65c9ecL,
	        0x14015c4fL, 0x63066cd9L, 0xfa0f3d63L, 0x8d080df5L,
	        0x3b6e20c8L, 0x4c69105eL, 0xd56041e4L, 0xa2677172L,
	        0x3c03e4d1L, 0x4b04d447L, 0xd20d85fdL, 0xa50ab56bL,
	        0x35b5a8faL, 0x42b2986cL, 0xdbbbc9d6L, 0xacbcf940L,
	        0x32d86ce3L, 0x45df5c75L, 0xdcd60dcfL, 0xabd13d59L,
	        0x26d930acL, 0x51de003aL, 0xc8d75180L, 0xbfd06116L,
	        0x21b4f4b5L, 0x56b3c423L, 0xcfba9599L, 0xb8bda50fL,
	        0x2802b89eL, 0x5f058808L, 0xc60cd9b2L, 0xb10be924L,
	        0x2f6f7c87L, 0x58684c11L, 0xc1611dabL, 0xb6662d3dL,
	        0x76dc4190L, 0x01db7106L, 0x98d220bcL, 0xefd5102aL,
	        0x71b18589L, 0x06b6b51fL, 0x9fbfe4a5L, 0xe8b8d433L,
	        0x7807c9a2L, 0x0f00f934L, 0x9609a88eL, 0xe10e9818L,
	        0x7f6a0dbbL, 0x086d3d2dL, 0x91646c97L, 0xe6635c01L,
	        0x6b6b51f4L, 0x1c6c6162L, 0x856530d8L, 0xf262004eL,
	        0x6c0695edL, 0x1b01a57bL, 0x8208f4c1L, 0xf50fc457L,
	        0x65b0d9c6L, 0x12b7e950L, 0x8bbeb8eaL, 0xfcb9887cL,
	        0x62dd1ddfL, 0x15da2d49L, 0x8cd37cf3L, 0xfbd44c65L,
	        0x4db26158L, 0x3ab551ceL, 0xa3bc0074L, 0xd4bb30e2L,
	        0x4adfa541L, 0x3dd895d7L, 0xa4d1c46dL, 0xd3d6f4fbL,
	        0x4369e96aL, 0x346ed9fcL, 0xad678846L, 0xda60b8d0L,
	        0x44042d73L, 0x33031de5L, 0xaa0a4c5fL, 0xdd0d7cc9L,
	        0x5005713cL, 0x270241aaL, 0xbe0b1010L, 0xc90c2086L,
	        0x5768b525L, 0x206f85b3L, 0xb966d409L, 0xce61e49fL,
	        0x5edef90eL, 0x29d9c998L, 0xb0d09822L, 0xc7d7a8b4L,
	        0x59b33d17L, 0x2eb40d81L, 0xb7bd5c3bL, 0xc0ba6cadL,
	        0xedb88320L, 0x9abfb3b6L, 0x03b6e20cL, 0x74b1d29aL,
	        0xead54739L, 0x9dd277afL, 0x04db2615L, 0x73dc1683L,
	        0xe3630b12L, 0x94643b84L, 0x0d6d6a3eL, 0x7a6a5aa8L,
	        0xe40ecf0bL, 0x9309ff9dL, 0x0a00ae27L, 0x7d079eb1L,
	        0xf00f9344L, 0x8708a3d2L, 0x1e01f268L, 0x6906c2feL,
	        0xf762575dL, 0x806567cbL, 0x196c3671L, 0x6e6b06e7L,
	        0xfed41b76L, 0x89d32be0L, 0x10da7a5aL, 0x67dd4accL,
	        0xf9b9df6fL, 0x8ebeeff9L, 0x17b7be43L, 0x60b08ed5L,
	        0xd6d6a3e8L, 0xa1d1937eL, 0x38d8c2c4L, 0x4fdff252L,
	        0xd1bb67f1L, 0xa6bc5767L, 0x3fb506ddL, 0x48b2364bL,
	        0xd80d2bdaL, 0xaf0a1b4cL, 0x36034af6L, 0x41047a60L,
	        0xdf60efc3L, 0xa867df55L, 0x316e8eefL, 0x4669be79L,
	        0xcb61b38cL, 0xbc66831aL, 0x256fd2a0L, 0x5268e236L,
	        0xcc0c7795L, 0xbb0b4703L, 0x220216b9L, 0x5505262fL,
	        0xc5ba3bbeL, 0xb2bd0b28L, 0x2bb45a92L, 0x5cb36a04L,
	        0xc2d7ffa7L, 0xb5d0cf31L, 0x2cd99e8bL, 0x5bdeae1dL,
	        0x9b64c2b0L, 0xec63f226L, 0x756aa39cL, 0x026d930aL,
	        0x9c0906a9L, 0xeb0e363fL, 0x72076785L, 0x05005713L,
	        0x95bf4a82L, 0xe2b87a14L, 0x7bb12baeL, 0x0cb61b38L,
	        0x92d28e9bL, 0xe5d5be0dL, 0x7cdcefb7L, 0x0bdbdf21L,
	        0x86d3d2d4L, 0xf1d4e242L, 0x68ddb3f8L, 0x1fda836eL,
	        0x81be16cdL, 0xf6b9265bL, 0x6fb077e1L, 0x18b74777L,
	        0x88085ae6L, 0xff0f6a70L, 0x66063bcaL, 0x11010b5cL,
	        0x8f659effL, 0xf862ae69L, 0x616bffd3L, 0x166ccf45L,
	        0xa00ae278L, 0xd70dd2eeL, 0x4e048354L, 0x3903b3c2L,
	        0xa7672661L, 0xd06016f7L, 0x4969474dL, 0x3e6e77dbL,
	        0xaed16a4aL, 0xd9d65adcL, 0x40df0b66L, 0x37d83bf0L,
	        0xa9bcae53L, 0xdebb9ec5L, 0x47b2cf7fL, 0x30b5ffe9L,
	        0xbdbdf21cL, 0xcabac28aL, 0x53b39330L, 0x24b4a3a6L,
	        0xbad03605L, 0xcdd70693L, 0x54de5729L, 0x23d967bfL,
	        0xb3667a2eL, 0xc4614ab8L, 0x5d681b02L, 0x2a6f2b94L,
	        0xb40bbe37L, 0xc30c8ea1L, 0x5a05df1bL, 0x2d02ef8dL 
        };

        public byte[] nubCANCrcDataBuf;
        public int nubCANCrcDataSize;
        public UInt32[] table = new UInt32[256];
        public UInt32 Crc32 = 0xFFFFFFFF;
        public UInt32 Crc32Stream = 0xFFFFFFFF;

        public void ReadFile(string file_path, out byte[] file_data)
        {
            FileStream fs = new FileStream(file_path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            file_data = new byte[fs.Length];
            br.Read(file_data, 0, (int)fs.Length);
 
            br.Close();
            fs.Close();
        }

        
        /*!
        *  @brief description for nswCANGetVbfInfo()
        *  @param[in]     None
        *  @param[out]    None
        *  @return        None
        *  @author        Name
        *  @Date          20180108
        */
        public int nswCANGetVbfInfo(byte type, byte[] data, int data_len, CAN_File f, out string strLog)
        {
            int 		ret = -1;
            int         chk_offset = 0;
            int         i = 0;
	        int	        crc_offset = 0;
	        int	        crc_size = 0;
	        int	        erase_size = 0;

            strLog = String.Format("Get vbf info,datalen=[0x{0:X}]\n", data_len);

            try
            {
                
                string strData = System.Text.Encoding.Default.GetString(data);
                chk_offset = strData.IndexOf("file_checksum");

                if (data_len < chk_offset)
                {
                    strLog += String.Format("data exceed![0x{0:X}][0x{1:X}]\n", data_len, chk_offset);

                    return ret;
                }


                // 1st block
                for (i = chk_offset; i < data_len; i++)
                {
                    if (data[i] == '}')
                    {
                        strLog += String.Format("find file_checksum @[0x{0:X}],find }} @[0x{1:X}],block 0 flash addr & block size & data0-1:\n", chk_offset, i);

                        i = i + 0x01;
                        //NEU_LOG_BUFF(&data[i], 10);

                        f.block_count = 0x01;

                        f.block_array[0].type = type;

                        Array.Copy(data, i, f.block_array[0].flash_addr, 0, 4);
                        i = i + 4;

                        Array.Copy(data, i, f.block_array[0].size, 0, 4);
                        i = i + 4;

                        //memcpy(&block->checksum[0], &data[i], BLOCK_CHECKSUM_SIZE);
                        //i = i + BLOCK_CHECKSUM_SIZE;

                        f.block_array[0].start_offset = i;
                        int blocksize = ((((int)(f.block_array[0].size)[0]) * 256 * 256 * 256) + (((int)(f.block_array[0].size)[1]) * 256 * 256) + (((int)(f.block_array[0].size)[2]) * 256) + (f.block_array[0].size)[3]);
                        i = i + blocksize;
                        f.block_array[0].end_offset = i - 0x01;
                        if (i > (data_len - 0x02))
                        {

                            strLog += String.Format("i error!=[0x{0:X}],block size=[0x{1:X}],start offset=[0x{2:X}],end offset=[0x{3:X}]\n", i, blocksize, f.block_array[0].start_offset, f.block_array[0].end_offset);

                            i = (data_len - 0x02);
                        }

                        Array.Copy(data, i, f.block_array[0].checksum, 0, 2);
                        i = i + 2;

                        if (f.block_array[0].end_offset > (data_len - 0x01))
                        {
                            strLog += String.Format("end offset err=[0x{0:X}],datalen=[0x{1:X}],i=[0x{2:X}]\n", f.block_array[0].end_offset, data_len, i);

                            f.block_array[0].end_offset = (data_len - 0x01);
                        }

                        ret = 0;

                        chk_offset = f.block_array[0].end_offset + 4 + 4 + 2 + 0x01;

                        break;
                    }
                }

                if (0 != ret)
                {
                    strLog += String.Format("find file_checksum @[0x{0:X}], can NOT find },end @[0x{1:X}]\n", chk_offset, i);

                    return ret;
                }

                if (chk_offset >= data_len)
                {
                    strLog += String.Format("no more block,next block data @[0x{0:X}],but totalsize=[0x{1:X}]\n", chk_offset, data_len);
                }
                else
                {
                    for (i = (f.block_array[f.block_count - 0x01].end_offset + 0x01 + 2); i < data_len; )
                    {
                        strLog += String.Format("i=[0x{0:X}],block %d flash addr & block size & data0-1:\n", i, f.block_count);
                        //NEU_LOG_BUFF(&data[i], 10);

                        f.block_array[f.block_count].type = type;
                        Array.Copy(data, i, f.block_array[f.block_count].flash_addr, 0, 4);
                        i = i + 4;

                        Array.Copy(data, i, f.block_array[f.block_count].size, 0, 4);
                        i = i + 4;

                        f.block_array[f.block_count].start_offset = i;

                        int blocksize = ((((int)(f.block_array[f.block_count].size)[0]) * 256 * 256 * 256) + (((int)(f.block_array[f.block_count].size)[1]) * 256 * 256) + (((int)(f.block_array[f.block_count].size)[2]) * 256) + (f.block_array[f.block_count].size)[3]);
                        i = i + blocksize;

                        f.block_array[f.block_count].end_offset = i - 0x01;

                        if (i > (data_len - 0x02))
                        {
                            strLog += String.Format("i error!=[0x{0:X}],block size=[0x{1:X}],start offset=[0x{2:X}],end offset=[0x{3:X}]\n", i, blocksize, f.block_array[f.block_count].start_offset, f.block_array[f.block_count].end_offset);

                            i = (data_len - 0x02);
                        }
                        Array.Copy(data, i, f.block_array[f.block_count].checksum, 0, 2);
                        i = i + 2;

                        f.block_count++;
                        if (f.block_count >= 100)
                        {
                            f.block_count = 100;

                            break;
                        }
                    }
                }

                f.block_array[f.block_count - 0x01].is_last = 0x01;
                strLog += String.Format("block=[%d] is the last block\n", f.block_count - 0x01);


                // calc crc32
                Crc32 = 0xFFFFFFFF;
                //memset(&nubCANCrcDataBuf[0], 0, sizeof(nubCANCrcDataBuf));
                nubCANCrcDataSize = 0;
                nubCANCrcDataBuf = new byte[data.Length];
                for (i = 0; i < f.block_count; i++)
                {
                    crc_offset = f.block_array[i].start_offset;
                    if (crc_offset > data_len - 1)
                    {
                        strLog += String.Format("crc offset error=[0x{0:X}]\n", crc_offset);
                        crc_offset = data_len - 1;
                    }
                    crc_size = ((((int)(f.block_array[i].size)[0]) * 256 * 256 * 256) + (((int)(f.block_array[i].size)[1]) * 256 * 256) + (((int)(f.block_array[i].size)[2]) * 256) + (f.block_array[i].size)[3]);
                    if ((nubCANCrcDataSize + crc_size) > data.Length)
                    {
                        strLog += String.Format("crc size error=[0x{0:X}],[0x{1:X}]\n", crc_size, nubCANCrcDataSize);

                        break;
                    }

                    strLog += String.Format("crc offset=[0x{0:X}],size=[0x{1:X}],\n", crc_offset, crc_size);
                    Array.Copy(data, crc_offset, nubCANCrcDataBuf, nubCANCrcDataSize, crc_size);
                    nubCANCrcDataSize = nubCANCrcDataSize + crc_size;
                }

                string str;
                nuwCANCalcChecksum(nubCANCrcDataBuf, nubCANCrcDataSize, out Crc32, out str);
                strLog += str;

                (f.crc32)[0] = (byte)((Crc32) / 256 / 256 / 256);
                (f.crc32)[1] = (byte)((Crc32) / 256 / 256);
                (f.crc32)[2] = (byte)((Crc32) / 256);
                (f.crc32)[3] = (byte)((Crc32) & 0xFF);

                // erase size
                //if (f.block_count > 0) {
                //    erase_size = FLIPW4(f->block_array[f->block_count - 1].flash_addr);
                //    if (erase_size >= FLIPW4(f->block_array[0].flash_addr)) {
                //        erase_size = erase_size - FLIPW4(f->block_array[0].flash_addr);
                //        erase_size = erase_size + FLIPW4(f->block_array[f->block_count - 1].size);
                //    }
                //    else {
                //        erase_size = 0;
                //        CAN_LOG_CRIT("erase size error!\n");
                //    }

                //    FLOPW4(f->erase_size, erase_size);
                //}

                // calc crc32 in stream
                strLog += "calculating crc in stream......";
                Crc32Stream = 0xFFFFFFFF;
                nubCANCrcDataSize = 0;
                string str2;
                UInt32 Crc32In = 0xFFFFFFFF;

                for (i = 0; i < f.block_count; i++)
                {
                    crc_offset = f.block_array[i].start_offset;
                    if (crc_offset > data_len - 1)
                    {
                        strLog += String.Format("crc offset error=[0x{0:X}]\n", crc_offset);
                        crc_offset = data_len - 1;
                    }
                    crc_size = ((((int)(f.block_array[i].size)[0]) * 256 * 256 * 256) + (((int)(f.block_array[i].size)[1]) * 256 * 256) + (((int)(f.block_array[i].size)[2]) * 256) + (f.block_array[i].size)[3]);
                    if ((nubCANCrcDataSize + crc_size) > data.Length)
                    {
                        strLog += String.Format("crc size error=[0x{0:X}],[0x{1:X}]\n", crc_size, nubCANCrcDataSize);

                        break;
                    }

                    strLog += String.Format("crc offset=[0x{0:X}],size=[0x{1:X}],\n", crc_offset, crc_size);
                    byte[] buf = new byte[crc_size];
                    Array.Copy(data, crc_offset, buf, 0, crc_size);
                    nubCANCrcDataSize = nubCANCrcDataSize + crc_size;
                    nuwCANCalcChecksum(Crc32In, buf, buf.Length, out Crc32Stream, out str2);
                    Crc32In = Crc32Stream;
                    strLog += str2;
                }

                UInt32 crctemp = Crc32Stream;
                Crc32Stream = Crc32Stream ^ 0xFFFFFFFF;

                strLog += String.Format("before xor=[0x{0:X}],after xor=[0x{1:X}]\n", crctemp, Crc32Stream);
	
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
                strLog += err;
                //throw;
            }            
	
	        return ret;
        }

        public UInt32 crc32_calc(UInt32 crc, byte[] input, int len)  
        {  
            int 		i;  
            byte 	index;  
	
            for(i=0; i<len; i++) {  
                index = (byte)((input[i] ^ crc) & 0xFF);
                crc = (UInt32)((crc >> 8) ^ ssh_crc32_tbl[index]);  
            } 
	
            return crc;  
        }  


        /*!
        *  @brief description for nuwCANCalcChecksum()
        *  @param[in]     None
        *  @param[out]    None
        *  @return        None
        *  @author        Name
        *  @Date          20180108
        */
        public int nuwCANCalcChecksum(byte[] data, int data_len, out UInt32 crc32, out string strLog)
        {
            UInt32 crc = 0xFFFFFFFF;
	
            crc = crc32_calc(0xFFFFFFFF, data, data_len);
	
	        crc32 = crc ^ 0xFFFFFFFF;


            strLog = String.Format("calc crc32,from[0x{0:X}{1:X}],to[0x{2:X}{3:X}],len=[0x{4:X}],before xor=[0x{5:X}],result=[0x{6:X}]\n",
            data[0],
            data[1],
            data[data_len - 2],
            data[data_len - 1],
            data_len,
            crc,
            crc32);


	        return 0;
        }

        // support stream
        public int nuwCANCalcChecksum(UInt32 crcInit, byte[] data, int data_len, out UInt32 crc32, out string strLog)
        {
            UInt32 crc = 0xFFFFFFFF;

            crc = crc32_calc(crcInit, data, data_len);

            //crc32 = crc ^ 0xFFFFFFFF;
            crc32 = crc;


            strLog = String.Format("calc crc32,from[0x{0:X}{1:X}],to[0x{2:X}{3:X}],len=[0x{4:X}],before xor=[0x{5:X}],result=[0x{6:X}],crcInit[0x{7:X}]\n",
            data[0],
            data[1],
            data[data_len - 2],
            data[data_len - 1],
            data_len,
            crc,
            crc32,
            crcInit);


            return 0;
        }






    }
}
