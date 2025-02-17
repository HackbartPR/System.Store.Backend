﻿using Domain.DTOs.Coupon;
using Domain.Responses;
using MediatR;

namespace Service.Product.Application.Features.Post;

public class PostProductCommand : IRequest<BaseResponse<ProductDto?>>
{
	/// <summary>
	/// Nome
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Preço
	/// </summary>
	public double Price { get; set; }

	/// <summary>
	/// Descrição
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Nome da Categoria a qual o produto pertence
	/// Esta propriedade deve ser uma entidade separada, mas para fins de estudo, será colocado dessa maneira.
	/// </summary>
	public string CategoryName { get; set; } = string.Empty;

	/// <summary>
	/// URL da imagem
	/// </summary>
	public string ImageUrl { get; set; } = string.Empty;
}
