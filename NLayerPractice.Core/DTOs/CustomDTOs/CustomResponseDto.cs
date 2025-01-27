﻿using System.Text.Json.Serialization;

namespace NLayerPractice.Core.DTOs.CustomDTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore] //I don't show status code to the client because they are already know this.
        public int StatusCode { get; set; }

        public List<string> Errors { get; set; }



        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T>
            {
                Data = data,
                StatusCode = statusCode,
                Errors = null

            };
        }

        public static CustomResponseDto<T> Success(int statusCode, IQueryable<Models.Product> products)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode,

            };
        }

        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode,
                Errors = null
            };
        }

        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode,
                Errors = new List<string> { error }
            };
        }
    }
}



