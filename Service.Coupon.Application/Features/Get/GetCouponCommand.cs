﻿using Domain.DTOs.Coupon;
using Domain.Requests;
using Domain.Responses;
using MediatR;

namespace Service.Coupon.Application.Features.Get;

/// <summary>
/// Representação da requisição para listar os cupons
/// </summary>
public class GetCouponCommand : BasePagedRequest, IRequest<BasePagedResponse<CouponDto>>
{
    /// <summary>
    /// Identificação
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Código do cupon
    /// </summary>
    public string? CouponCode { get; set; }
}
