import json
import sys
from pathlib import Path
import plotly.graph_objects as go
from plotly.subplots import make_subplots

BASE_DIR = Path(__file__).resolve().parent
JSON_PATH = BASE_DIR / "input.json"
OUT_DIR = BASE_DIR / "plots"

# Подписи осей. Единицы для эллиптичности вытянем из JSON
Y_LABELS = {
    "delta_epsilon": "Δε, л/моль·см",
    "delta_a": "ΔA",
    "optical_rotation": "φ, град"
}

def load_data(path: Path) -> dict:
    if not path.exists():
        sys.exit(f"Ошибка: не найден {path}. Сначала сделайте JSON в WinForms.")
    with open(path, encoding="utf-8") as f:
        data = json.load(f)

    if "results" not in data:
        sys.exit("Ошибка: в JSON нет блока 'results'.")
    return data

def get_subtitle(data: dict) -> str:
    e = data["experiment"]
    # Формат подзаголовка: диапазон, толщина, концентрация
    return f"λ: {e['wavelength_min']}-{e['wavelength_max']} нм, d={e['thickness_mm']} мм, c={e['concentration']} {e['concentration_units']}"

def build_cd_plot(data: dict) -> go.Figure:
    res = data["results"]
    units = data["output"]["units"]
    wl = res["wavelength"]

    fig = make_subplots(
        rows=1, cols=3,
        subplot_titles=("Δε", "ΔA", f"θ, {units}")
    )

    # Цвета подобраны для лучше читаемости
    plots = [
        ("delta_epsilon", "#1f77b4"),
        ("delta_a", "#2ca02c"),
        ("ellipticity", "#d62728")
    ]

    for col, (key, color) in enumerate(plots, start=1):
        y_title = Y_LABELS.get(key, f"θ, {units}")
        fig.add_trace(
            go.Scatter(x=wl, y=res[key], mode="lines", name=key,
                       line=dict(color=color, width=2)),
            row=1, col=col
        )
        fig.update_xaxes(title_text="λ, нм", row=1, col=col)
        fig.update_yaxes(title_text=y_title, row=1, col=col)

    fig.update_layout(
        title=f"CD спектры<br><sup>{get_subtitle(data)}</sup>",
        template="plotly_white", showlegend=False, height=500,
        margin=dict(t=80)
    )
    return fig

def build_ord_plot(data: dict) -> go.Figure:
    res = data["results"]
    fig = go.Figure()

    fig.add_trace(go.Scatter(
        x=res["wavelength"], y=res["optical_rotation"], mode="lines",
        line=dict(color="#ff7f0e", width=2)
    ))

    # Нулевая линия, чтобы была видна смена знака (эффект Коттона)
    fig.add_hline(y=0, line_width=1, line_color="gray", opacity=0.6)

    fig.update_layout(
        title=f"ORD (Крамерс-Кронига)<br><sup>{get_subtitle(data)}</sup>",
        xaxis_title="λ, нм", yaxis_title="φ, град",
        template="plotly_white", height=500,
        margin=dict(t=80)
    )
    return fig

def build_combined_plot(data: dict) -> go.Figure:
    res = data["results"]
    units = data["output"]["units"]

    # Две оси Y для CD и ORD
    fig = make_subplots(specs=[[{"secondary_y": True}]])

    fig.add_trace(
        go.Scatter(x=res["wavelength"], y=res["ellipticity"], mode="lines",
                   name="CD (θ)", line=dict(color="#1f77b4", width=2)),
        secondary_y=False
    )
    fig.add_trace(
        go.Scatter(x=res["wavelength"], y=res["optical_rotation"], mode="lines",
                   name="ORD (φ)", line=dict(color="#ff7f0e", width=2)),
        secondary_y=True
    )

    fig.update_yaxes(title_text=f"θ, {units}", secondary_y=False, color="#1f77b4")
    fig.update_yaxes(title_text="φ, град", secondary_y=True, color="#ff7f0e")
    fig.update_xaxes(title_text="λ, нм")

    fig.update_layout(
        title=f"CD и ORD<br><sup>{get_subtitle(data)}</sup>",
        template="plotly_white", height=500, hovermode="x unified",
        margin=dict(t=80)
    )
    return fig

def build_3d_plot(data: dict) -> go.Figure:
    surf = data["results"]["surface_3d"]
    units = data["output"]["units"]

    # z_ellipticity имеет размерность (3, 301) — (концентрации, длины волн)
    fig = go.Figure(data=[go.Surface(
        x=surf["x_wavelength"], y=surf["y_concentration"], z=surf["z_ellipticity"],
        colorscale="Viridis", colorbar=dict(title=f"θ, {units}")
    )])

    fig.update_layout(
        title=f"Зависимость θ от λ и c<br><sup>{get_subtitle(data)}</sup>",
        scene=dict(
            xaxis_title="λ, нм",
            yaxis_title=f"c, {data['experiment']['concentration_units']}",
            zaxis_title=f"θ, {units}"
        ),
        template="plotly_white", height=700,
        margin=dict(t=80)
    )
    return fig

def main():
    data = load_data(JSON_PATH)
    OUT_DIR.mkdir(parents=True, exist_ok=True)

    figures = {
        "cd_2d.html": build_cd_plot(data),
        "ord_2d.html": build_ord_plot(data),
        "combined.html": build_combined_plot(data),
        "surface_3d.html": build_3d_plot(data)
    }

    for name, fig in figures.items():
        path = OUT_DIR / name
        fig.write_html(path, include_plotlyjs="cdn", full_html=True)
        print(f"Сохранено: {path}")

    print(f"\nГотово. Файлы лежат в {OUT_DIR}")

if __name__ == "__main__":
    main()