using HalconDotNet;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public partial class HalconDev
{
    private HTuple windowHandle;
    public List<string[]> action(int threhold_down, int threhold_up, int area_down,int area_up,PictureBox pcb,string path)
    {

        List<string[]> dic = new List<string[]>();
        // Local iconic variables 
        HObject ho_image, ho_r, ho_g, ho_b, ho_h, ho_s;
        HObject ho_v, ho_ImageEmphasize, ho_Region, ho_ConnectedRegions;
        HObject ho_RegionClosing, ho_SelectedRegions, ho_RegionFillUp;
        HObject ho_ImageReduced, ho_ImageReduced1, ho_Region1, ho_ConnectedRegions1;
        HObject ho_SelectedRegions1, ho_SortedRegions, ho_ImageInvert;

        // Local control variables 

        HTuple hv_Width = new HTuple(), hv_Height = new HTuple();
        HTuple hv_WindowHandle = new HTuple(), hv_OCRHandle = new HTuple();
        HTuple hv_Class = new HTuple(), hv_Confidence = new HTuple();
        // Initialize local and output iconic variables 
        HOperatorSet.GenEmptyObj(out ho_image);
        HOperatorSet.GenEmptyObj(out ho_r);
        HOperatorSet.GenEmptyObj(out ho_g);
        HOperatorSet.GenEmptyObj(out ho_b);
        HOperatorSet.GenEmptyObj(out ho_h);
        HOperatorSet.GenEmptyObj(out ho_s);
        HOperatorSet.GenEmptyObj(out ho_v);
        HOperatorSet.GenEmptyObj(out ho_ImageEmphasize);
        HOperatorSet.GenEmptyObj(out ho_Region);
        HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
        HOperatorSet.GenEmptyObj(out ho_RegionClosing);
        HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
        HOperatorSet.GenEmptyObj(out ho_RegionFillUp);
        HOperatorSet.GenEmptyObj(out ho_ImageReduced);
        HOperatorSet.GenEmptyObj(out ho_ImageReduced1);
        HOperatorSet.GenEmptyObj(out ho_Region1);
        HOperatorSet.GenEmptyObj(out ho_ConnectedRegions1);
        HOperatorSet.GenEmptyObj(out ho_SelectedRegions1);
        HOperatorSet.GenEmptyObj(out ho_SortedRegions);
        HOperatorSet.GenEmptyObj(out ho_ImageInvert);
        if (HDevWindowStack.IsOpen())
        {
            HOperatorSet.CloseWindow(HDevWindowStack.Pop());
        }

        if (HDevWindowStack.IsOpen())
        {
            HOperatorSet.ClearWindow(HDevWindowStack.GetActive());
        }
        ho_image.Dispose();
        HOperatorSet.ReadImage(out ho_image, path);
        hv_Width.Dispose(); hv_Height.Dispose();
        HOperatorSet.GetImageSize(ho_image, out hv_Width, out hv_Height);
        hv_WindowHandle.Dispose();
        HOperatorSet.OpenWindow(0, 0, pcb.Width, pcb.Height, pcb.Handle, "visible", "", out windowHandle);
        HDevWindowStack.Push(windowHandle);
        
        //将图片转化为rgb三通道
        ho_r.Dispose(); ho_g.Dispose(); ho_b.Dispose();
        HOperatorSet.Decompose3(ho_image, out ho_r, out ho_g, out ho_b);
        //转为hsv 色调 饱和度 明度值
        ho_h.Dispose(); ho_s.Dispose(); ho_v.Dispose();
        HOperatorSet.TransFromRgb(ho_r, ho_g, ho_b, out ho_h, out ho_s, out ho_v, "hsv");
        //提升图片对比度
        ho_ImageEmphasize.Dispose();
        HOperatorSet.Emphasize(ho_s, out ho_ImageEmphasize, hv_Width, hv_Height, 1);

        ho_Region.Dispose();
        HOperatorSet.Threshold(ho_ImageEmphasize, out ho_Region, 255,255);

        ho_ConnectedRegions.Dispose();
        HOperatorSet.Connection(ho_Region, out ho_ConnectedRegions);

        ho_RegionClosing.Dispose();
        HOperatorSet.ClosingRectangle1(ho_ConnectedRegions, out ho_RegionClosing, 50, 50);

        //按照最大面积选
        ho_SelectedRegions.Dispose();
        HOperatorSet.SelectShapeStd(ho_RegionClosing, out ho_SelectedRegions, "max_area", 70);
        //填充选出区域的孔洞
        ho_RegionFillUp.Dispose();
        HOperatorSet.FillUp(ho_SelectedRegions, out ho_RegionFillUp);
        //抠图
        ho_ImageReduced.Dispose();
        HOperatorSet.ReduceDomain(ho_ImageEmphasize, ho_RegionFillUp, out ho_ImageReduced
            );
        //抠出原图
        ho_ImageReduced1.Dispose();
        HOperatorSet.ReduceDomain(ho_image, ho_RegionFillUp, out ho_ImageReduced1);
        //识别
        ho_Region1.Dispose();
        HOperatorSet.Threshold(ho_ImageReduced, out ho_Region1, threhold_down, threhold_up); // 0 100
        //打断连接区域
        ho_ConnectedRegions1.Dispose();
        HOperatorSet.Connection(ho_Region1, out ho_ConnectedRegions1);
        //筛选显示区域
        ho_SelectedRegions1.Dispose();
        HOperatorSet.SelectShape(ho_ConnectedRegions1, out ho_SelectedRegions1, "area",
            "and", area_down, area_up); //4014, 19840.76
        //排序区域
        ho_SortedRegions.Dispose();
        HOperatorSet.SortRegion(ho_SelectedRegions1, out ho_SortedRegions, "character",
            "true", "row");
        //反转图片
        ho_ImageInvert.Dispose();
        HOperatorSet.InvertImage(ho_ImageReduced1, out ho_ImageInvert);
        
            //开始识别
        hv_OCRHandle.Dispose();
        HOperatorSet.ReadOcrClassMlp("Industrial_0-9A-Z_NoRej.omc", out hv_OCRHandle);
        hv_Class.Dispose(); hv_Confidence.Dispose();
        HOperatorSet.DoOcrMultiClassMlp(ho_SortedRegions, ho_ImageInvert, hv_OCRHandle,
            out hv_Class, out hv_Confidence);
        if (HDevWindowStack.IsOpen())
        {
            dic.Clear();
            HOperatorSet.DispObj(ho_ImageReduced1, windowHandle);
            HOperatorSet.DispObj(ho_image, windowHandle);
            HOperatorSet.DispObj(ho_Region1, windowHandle);
            HOperatorSet.WriteString(windowHandle,hv_Class);
            string[] cls = hv_Class.ToSArr();
            string[] confidence = hv_Confidence.ToSArr();
            for (int i = 0;i< cls.Length;i++)
            {
                dic.Add(new string[] { cls[i], confidence[i] }); 
            }
        }
        ho_image.Dispose();
        ho_r.Dispose();
        ho_g.Dispose();
        ho_b.Dispose();
        ho_h.Dispose();
        ho_s.Dispose();
        ho_v.Dispose();
        ho_ImageEmphasize.Dispose();
        ho_Region.Dispose();
        ho_ConnectedRegions.Dispose();
        ho_RegionClosing.Dispose();
        ho_SelectedRegions.Dispose();
        ho_RegionFillUp.Dispose();
        ho_ImageReduced.Dispose();
        ho_ImageReduced1.Dispose();
        ho_Region1.Dispose();
        ho_ConnectedRegions1.Dispose();
        ho_SelectedRegions1.Dispose();
        ho_SortedRegions.Dispose();
        ho_ImageInvert.Dispose();

        hv_Width.Dispose();
        hv_Height.Dispose();
        hv_WindowHandle.Dispose();
        hv_OCRHandle.Dispose();
        hv_Class.Dispose();
        hv_Confidence.Dispose();
        return dic;

    }



}


